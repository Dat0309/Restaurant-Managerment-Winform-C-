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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                tables.Add(new Tables((int)reader["ID"], (string)reader["Name"], (int)reader["Status"], (int)reader["Capacity"]));

                var item = new CustomControl.TableControll();
                item.LoadTableName((string)reader["Name"]);
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
                foods.Add(new Food((int)reader["ID"], (string)reader["Name"], (string)reader["Unit"], (int)reader["FoodCategoryID"],
                    (int)reader["Price"], (string)reader["Notes"], (string)reader["Picture"]));

                var item = new CustomControl.DetailFood();
                item.LoadFood((string)reader["Name"],(int)reader["Price"],(string)reader["Picture"]);

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

            TableForm frm = new TableForm();
            frm.initUI(tables);
            frm.ShowDialog(this);
        }
    }
}
