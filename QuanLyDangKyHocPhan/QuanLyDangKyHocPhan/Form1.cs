using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDangKyHocPhan.Model;

namespace QuanLyDangKyHocPhan
{
    public partial class Form1 : Form
    {
        public delegate void SendFood(Tables table,string billId);
        public delegate void ReceiveFood(Food food);
        private string curBill,curBillDetail;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region cac ham xu ly

        private void SetValue(Tables value,string billId)
        {
            this.lbNameTable.Text = "Bàn " + value.name;
            curBill = billId;
        }

        private void InsertBillDetail(string billId, int foodId, int quantity)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "EXECUTE BillDetail_Insert @id output,@billId,@foodId,@quantity";

            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters.Add("@billId", SqlDbType.Int);
            cmd.Parameters.Add("@foodId", SqlDbType.Int);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);

            cmd.Parameters["@id"].Direction = ParameterDirection.Output;

            cmd.Parameters["@billId"].Value = int.Parse(billId);
            cmd.Parameters["@foodId"].Value = foodId;
            cmd.Parameters["@quantity"].Value=quantity;

            conn.Open();

            cmd.ExecuteNonQuery();
            curBillDetail = cmd.Parameters["@id"].Value.ToString();
            conn.Close();
        }

        private void SetFood(Food value)
        {

            var item = new CustomControl.OrderControl();

            InsertBillDetail(curBill, value.Id, item.GetQuantity());
            item.initUI(value.Name, DateTime.Now.ToShortDateString(), value.Price, 1,value.Id,int.Parse(curBill),int.Parse(curBillDetail));
            flOrder.Controls.Add(item);
            LoadAmount();
        }
        
        private void LoadAmount()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "EXECUTE Amount_Update @id";
            
            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters["@id"].Value = curBill;
            conn.Open();

            cmd.ExecuteNonQuery();
            cmd.CommandText = $"Select * from Bills where ID = {curBill}";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbSumPrice.Text = (reader["Amount"]).ToString();
                txtDiscount.Text = (reader["Discount"]).ToString();
                txtTax.Text = (reader["Tax"]).ToString();

                int discount = int.Parse(lbSumPrice.Text) * int.Parse(txtDiscount.Text);
                int tax = int.Parse(lbSumPrice.Text) * int.Parse(txtTax.Text);

                txtAmount.Text = (int.Parse(lbSumPrice.Text) - discount - tax).ToString();            
            }

            conn.Close();

        }
        #endregion

        private void btnListTable_Click(object sender, EventArgs e)
        {
            List<Tables> tables = new List<Tables>();
            flpFoodList.Controls.Clear();
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM [Table]";
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var table = new Tables((int)reader["ID"], (string)reader["Name"], (int)reader["Status"], (int)reader["Capacity"]);
                tables.Add(table);

                var item = new CustomControl.TableControll();
                item.LoadTableName((string)reader["Name"],table);
                item.LoadStatus((int)reader["Status"]);

                flpFoodList.Controls.Add(item);
            }

            conn.Close();

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            List<Food> foods = new List<Food>();
            flpFoodList.Controls.Clear();
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM Food";
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var food = new Food((int)reader["ID"], (string)reader["Name"], (string)reader["Unit"], (int)reader["FoodCategoryID"],
                    (int)reader["Price"], (string)reader["Notes"], (string)reader["Picture"]);
                foods.Add(food);

                var item = new CustomControl.DetailFood(SetFood);
                item.LoadFood((string)reader["Name"],(int)reader["Price"],(string)reader["Picture"],food);

                flpFoodList.Controls.Add(item);
            }

            conn.Close();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            List<Tables> tables = new List<Tables>();
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM [Table]";
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(new Tables((int)reader["ID"], (string)reader["Name"], (int)reader["Status"], (int)reader["Capacity"]));

            }

            conn.Close();

            TableForm frm = new TableForm(SetValue);
            frm.initUI(tables);
            frm.ShowDialog(this);
            frm.FormClosed += new FormClosedEventHandler(frmClosed);
        }

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            btnListTable_Click(sender, e);
        }
    }
}
