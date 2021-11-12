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
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        public void LoadDetail(string billID)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE BillDetail_GetById @id";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = billID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                adapter.Fill(dt);
                dgvDetailBill.DataSource = dt;
                dgvDetailBill.Columns[0].ReadOnly = true;

                dgvDetailBill.Columns[0].HeaderText = "Mã";
                dgvDetailBill.Columns[1].HeaderText = "Tên món ăn";
                dgvDetailBill.Columns[2].HeaderText = "Số lượng";
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }
    }
}
