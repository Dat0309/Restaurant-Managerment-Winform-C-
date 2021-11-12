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
    public partial class BillOrderForm : Form
    {
        public BillOrderForm()
        {
            InitializeComponent();
        }
        public void LoadBills()
        {
            dgvBills.Columns.Clear();
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = $"Select * from bills";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();

            adapter.Fill(dt);
            dgvBills.DataSource = dt;
            dgvBills.Columns[0].ReadOnly = true;

            dgvBills.Columns[0].HeaderText = "Mã hoá đơn";
            dgvBills.Columns[1].HeaderText = "Tên hoá đơn";
            dgvBills.Columns[2].HeaderText = "Mã bàn ăn";
            dgvBills.Columns[3].HeaderText = "Số tiền";
            dgvBills.Columns[4].HeaderText = "Khuyến mãi";
            dgvBills.Columns[5].HeaderText = "Thuế";
            dgvBills.Columns[6].HeaderText = "Thanh toán";
            dgvBills.Columns[7].HeaderText = "Ngày nhập";
            dgvBills.Columns[8].HeaderText = "Nhân viên";

            conn.Close();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE Bills_GetByDate @date";

                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);
                cmd.Parameters["@date"].Value = dtpDate.Value.ToShortDateString();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                adapter.Fill(dt);
                cmd.CommandText = "Select SUM(Amount) from Bills where CheckoutDate = @date";

                var doanhThu = cmd.ExecuteScalar();
                txtDoanhThu.Text = doanhThu.ToString();

                conn.Close();

                dgvBills.DataSource = dt;
                dgvBills.Columns[0].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            var billID = dgvBills.SelectedRows[0].Cells[0].Value.ToString();

            BillDetailForm frm = new BillDetailForm();
            frm.LoadDetail(billID);
            frm.ShowDialog(this);
        }
    }
}
