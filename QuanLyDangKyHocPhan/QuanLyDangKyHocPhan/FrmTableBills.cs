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

namespace QuanLyDangKyHocPhan
{
    public partial class FrmTableBills : Form
    {
        string idTable;
        public FrmTableBills()
        {
            InitializeComponent();
        }

        public void LoadBills(string TableID)
        {
            this.idTable = TableID;
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = "SELECT DISTINCT CheckoutDate FROM Bills WHERE TableID = " + TableID;

            sqlConnection.Open();

            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            this.Text = "Danh muc hoa don";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();

            da.Fill(ds, "Bills");
            DataTable dt = ds.Tables[0];
            DataRow row = null;

            foreach (DataRow item in dt.Rows)
            {
                row = item;
                lbxDate.Items.Add(item["CheckoutDate"]);
            }

            sqlConnection.Close();
            da.Dispose();
        }

        private void lbxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectDate = lbxDate.SelectedItem.ToString();

            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = String.Format("select b.ID,b.Name,b.Amount,b.Discount, b.Account, f.Name, bd.Quantity " +
                "from Bills b, BillDetails bd, Food f " +
                "where TableID = {0} and b.ID = bd.InvoiceID and CheckoutDate = '{1}' and f.ID = bd.FoodID", idTable, selectDate);

            sqlConnection.Open();

            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvTableBills.DataSource = dt;
            dgvTableBills.Columns[0].ReadOnly = true;

            sqlConnection.Close();
            da.Dispose();
        }
    }
}
