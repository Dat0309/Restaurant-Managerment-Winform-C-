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
    public partial class BillForm : Form
    {
        private int tableId;
        private string billId;
        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateStatusTable(int status)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "EXECUTE TableStatus_Update @id,@status";

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@status", SqlDbType.Int);

            cmd.Parameters["@id"].Value = tableId;
            cmd.Parameters["@status"].Value = status;

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Update status Bills
        private void UpdateStatusBill(bool status)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "EXECUTE BillsStatus_Update @id,@status";

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@status", SqlDbType.Bit);

            cmd.Parameters["@id"].Value = billId;
            cmd.Parameters["@status"].Value = status;

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void LoadBills(int tableId)
        {
            dgvBills.Columns.Clear();
            this.tableId = tableId;
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = $"Select * from bills where TableID = {tableId}";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();

            adapter.Fill(dt);
            dgvBills.DataSource = dt;
            dgvBills.Columns[0].ReadOnly = true;

            dgvBills.Columns[0].HeaderText = "Mã hoá đơn";
            dgvBills.Columns[0].HeaderText = "Tên hoá đơn";
            dgvBills.Columns[0].HeaderText = "Mã bàn ăn";
            dgvBills.Columns[0].HeaderText = "Số tiền";
            dgvBills.Columns[0].HeaderText = "Khuyến mãi";
            dgvBills.Columns[0].HeaderText = "Thuế";
            dgvBills.Columns[0].HeaderText = "Thanh toán";
            dgvBills.Columns[0].HeaderText = "Ngày nhập";
            dgvBills.Columns[0].HeaderText = "Nhân viên";

            conn.Close();
        }

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            var billID = dgvBills.SelectedRows[0].Cells[0].Value.ToString();

            BillDetailForm frm = new BillDetailForm();
            frm.LoadDetail(billID);
            frm.ShowDialog(this);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int index = dgvBills.CurrentRow.Index;
            if (index != null)
            {
                billId = dgvBills.Rows[index].Cells[0].Value.ToString();
                UpdateStatusTable(0);
                UpdateStatusBill(true);

                MessageBox.Show("Thanh toán thành công");
                this.LoadBills(tableId);
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvBills_Click(object sender, EventArgs e)
        {
            int index = dgvBills.CurrentRow.Index;
            if (index != null)
            {
                lbSumPrice.Text = dgvBills.Rows[index].Cells["Amount"].Value.ToString();
                txtDiscount.Text = dgvBills.Rows[index].Cells["Discount"].Value.ToString();
                txtTax.Text = dgvBills.Rows[index].Cells["Tax"].Value.ToString();

                int discount = int.Parse(lbSumPrice.Text) * int.Parse(txtDiscount.Text);
                int tax = int.Parse(lbSumPrice.Text) * int.Parse(txtTax.Text);

                txtAmount.Text = (int.Parse(lbSumPrice.Text) - discount - tax).ToString();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int index = dgvBills.CurrentRow.Index;
            if (index != null)
            {
                billId = dgvBills.Rows[index].Cells[0].Value.ToString();
                UpdateStatusTable(0);
                
            }
        }
    }
}
