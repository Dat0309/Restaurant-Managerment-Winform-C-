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
    public partial class TableInfoForm : Form
    {
        public TableInfoForm()
        {
            InitializeComponent();
        }

        public void LoadTable()
        {
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = "SELECT * FROM [TABLE]";

            sqlConnection.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            this.Text = "Danh sach tat ca cac ban";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Table");
            adapter.Fill(dt);

            dgvTable.DataSource = dt;
            dgvTable.Columns[0].ReadOnly = true;
            dgvTable.Columns[0].HeaderText = "Mã bàn";
            dgvTable.Columns[1].HeaderText = "Tên bàn";
            dgvTable.Columns[2].HeaderText = "Tình trạng";
            dgvTable.Columns[3].HeaderText = "Số chỗ";

            sqlConnection.Close();
            adapter.Dispose();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtName.Text)) return false;
            else if (string.IsNullOrEmpty(cbbStatus.Text)) return false;
            else if (string.IsNullOrEmpty(txtCapacity.Text)) return false;
            return true;
        }
        private void ResetForm()
        {
            txtName.Text = "";
            cbbStatus.Text = "";
            txtCapacity.Text = "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = connection.CreateCommand();

                connection.Open();

                command.CommandText = "SELECT Name FROM [Table] WHERE Name = '" + txtName.Text + "'";
                var check = command.ExecuteScalar();

                if (check == null)
                {
                    command.CommandText = string.Format("insert into [Table](Name, Status, Capacity) values (N'{0}', {1}, {2})",
                        txtName.Text, cbbStatus.Text == "Trống" ? "0" : "1", txtCapacity.Text);

                    int numOfRows = command.ExecuteNonQuery();
                    if (numOfRows == 1)
                    {
                        LoadTable();
                        ResetForm();
                        MessageBox.Show("Them tai khoan moi thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Loi");
                    }
                }
                else
                {
                    MessageBox.Show("ban da ton tai, xin thu lai");
                }
                connection.Close();
            }
            else
                MessageBox.Show("Vui long nhap day du thong tin", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection sqlConn = new SqlConnection(connectionString);
                SqlCommand sqlComd = sqlConn.CreateCommand();
                string id = dgvTable.SelectedRows[0].Cells[0].Value.ToString();
                sqlConn.Open();

                sqlComd.CommandText = "SELECT Name FROM [Table] WHERE Name = '" + txtName.Text + "'";
                var check = sqlComd.ExecuteScalar();

                if (check == null)
                {

                    sqlComd.CommandText = string.Format("UPDATE [Table] SET Name = N'{0}', Status = {1}, Capacity = {2} WHERE ID = {3} ",
                        txtName.Text, cbbStatus.Text == "Trống" ? "0" : "1", txtCapacity.Text, id);


                    int numOfRows = sqlComd.ExecuteNonQuery();

                    if (numOfRows == 1)
                    {
                        LoadTable();
                        ResetForm();
                        MessageBox.Show("Cap nhat ban thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ban da ton tai, xin thu lai");
                }
                sqlConn.Close();
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTable.SelectedRows.Count == 0) return;
                var rowSelect = dgvTable.SelectedRows[0];
                string id = dgvTable.SelectedRows[0].Cells[0].Value.ToString();

                string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection sqlConn = new SqlConnection(connectionString);
                SqlCommand sqlComd = sqlConn.CreateCommand();

                string query = string.Format("Delete from Bills Where TableID = {0}", id);
                sqlComd.CommandText = query;

                sqlConn.Open();

                sqlComd.ExecuteNonQuery();

                sqlComd.CommandText = "Delete from [Table] WHERE ID = " + id;
                sqlComd.ExecuteNonQuery();

                dgvTable.Rows.Remove(rowSelect);
                LoadTable();
                ResetForm();
                MessageBox.Show("Da xoa thanh cong");

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Error");
            }
        }

        private void dgvTable_Click(object sender, EventArgs e)
        {
            int index = dgvTable.CurrentRow.Index;

            txtName.Text = dgvTable.Rows[index].Cells["Name"].Value.ToString();
            cbbStatus.Text = dgvTable.Rows[index].Cells["Status"].Value.ToString() == "0" ? "Trống" : "Có người";
            txtCapacity.Text = dgvTable.Rows[index].Cells["Capacity"].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void tsmViewBills_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 0) return;
            var rowSelect = dgvTable.SelectedRows[0];
            string id = dgvTable.SelectedRows[0].Cells[0].Value.ToString();

            FrmTableBills frm = new FrmTableBills();
            frm.Show(this);
            frm.LoadBills(id);
        }

        private void tsmViewMemoryBills_Click(object sender, EventArgs e)
        {
            BillsMemoryForm frm = new BillsMemoryForm();
            frm.Show(this);
            frm.LoadMemory();
        }
    }
}
