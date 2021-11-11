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
    public partial class BillsMemoryForm : Form
    {
        public BillsMemoryForm()
        {
            InitializeComponent();
        }
        public void LoadMemory()
        {
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = String.Format("select t.Name,COUNT(b.Name) as N'SL Hóa đơn',SUM(b.Amount) as N'Tổng tiền', SUM(b.Tax) as N'Tổng thuế', SUM(b.Discount) as N'Tổng giảm giá' " +
                "from Bills b,Account a,[Table] t " +
                "where b.Account = a.AccountName and b.TableID = t.ID " +
                "GROUP BY t.Name");

            sqlConnection.Open();

            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            this.Text = "Danh sach hoa don";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Table");
            da.Fill(dt);

            dgvDetail.DataSource = dt;
            dgvDetail.ReadOnly = true;

            sqlConnection.Close();
            da.Dispose();
        }
    }
}
