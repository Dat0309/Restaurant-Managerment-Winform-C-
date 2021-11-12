using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        private void LoadAccount()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from Account";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
            dgvAccount.Columns[0].ReadOnly = true;
            VietSub();

            for (int i = 0; i < dgvAccount.RowCount - 1; i++)
            {
                MahoaMD5(dgvAccount.Rows[i].Cells["Password"].Value.ToString(), i);
            }

            conn.Close();
        }

        private void MahoaMD5(string pass, int index)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            dgvAccount.Rows[index].Cells["Password"].Value = sb.ToString();
        }

        private void dgvAccount_Click(object sender, EventArgs e)
        {
            int index = dgvAccount.CurrentRow.Index;
            if (index != null)
            {
                txtAccountName.Text = dgvAccount.Rows[index].Cells["AccountName"].Value.ToString();
                txtPass.Text = dgvAccount.Rows[index].Cells["Password"].Value.ToString();
                txtFullName.Text = dgvAccount.Rows[index].Cells["FullName"].Value.ToString();
                txtEmail.Text = dgvAccount.Rows[index].Cells["Email"].Value.ToString();
                mtbPhone.Text = dgvAccount.Rows[index].Cells["Tell"].Value.ToString();

                btnUpdate.Enabled = true;
            }
        }

        private void ResetForm()
        {
            txtAccountName.Text = "";
            txtPass.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            mtbPhone.Text = "";
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                try
                {
                    string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                    SqlConnection conn = new SqlConnection(connString);

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE Account_Insert @account,@pass,@fullname,@email,@tell,@date";

                    cmd.Parameters.Add("@account", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 200);
                    cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
                    cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
                    cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);

                    cmd.Parameters["@account"].Value = txtAccountName.Text;
                    cmd.Parameters["@pass"].Value = txtPass.Text;
                    cmd.Parameters["@fullname"].Value = txtFullName.Text;
                    cmd.Parameters["@email"].Value = txtEmail.Text;
                    cmd.Parameters["@tell"].Value = mtbPhone.Text;
                    cmd.Parameters["@date"].Value = DateTime.Now.ToShortDateString();

                    conn.Open();

                    int numOfRows = cmd.ExecuteNonQuery();

                    if (numOfRows == 1)
                    {
                        LoadAccount();
                        ResetForm();
                        MessageBox.Show("Them tai khoan thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error");
                }
            }
            else
            {
                MessageBox.Show("Loi", "Vui lòng điền đủ thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                try
                {
                    string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                    SqlConnection conn = new SqlConnection(connString);

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE Account_Update @account,@pass,@fullname,@email,@tell,@date";

                    cmd.Parameters.Add("@account", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 200);
                    cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
                    cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
                    cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);

                    cmd.Parameters["@account"].Value = txtAccountName.Text;
                    cmd.Parameters["@pass"].Value = txtPass.Text;
                    cmd.Parameters["@fullname"].Value = txtFullName.Text;
                    cmd.Parameters["@email"].Value = txtEmail.Text;
                    cmd.Parameters["@tell"].Value = mtbPhone.Text;
                    cmd.Parameters["@date"].Value = DateTime.Now.ToShortDateString();

                    conn.Open();

                    int numOfRows = cmd.ExecuteNonQuery();

                    if (numOfRows == 1)
                    {
                        LoadAccount();
                        ResetForm();
                        MessageBox.Show("Cap nhat tai khoan thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error");
                }

            }
            else
            {
                MessageBox.Show("Loi", "Vui lòng điền đủ thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void dgvAccount_DoubleClick(object sender, EventArgs e)
        {
            var name = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
            RoleForm frm = new RoleForm();
            frm.LoadRole(name);
            frm.ShowDialog(this);
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                string defaultPass = "123456";
                string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection sqlConn = new SqlConnection(connectionString);
                SqlCommand sqlComd = sqlConn.CreateCommand();

                sqlComd.CommandText = string.Format("UPDATE Account SET Password = '{1}' WHERE AccountName = '{0}' ",
                    txtAccountName.Text, defaultPass);

                sqlConn.Open();

                sqlComd.ExecuteNonQuery();
                MessageBox.Show("Cap nhat thanh cong");
                LoadAccount();
                ResetForm();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Error");
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtAccountName.Text)) return false;
            else if (string.IsNullOrEmpty(txtPass.Text)) return false;
            else if (string.IsNullOrEmpty(txtEmail.Text)) return false;
            else if (string.IsNullOrEmpty(txtFullName.Text)) return false;
            return true;
        }

        private void VietSub()
        {
            dgvAccount.Columns[0].HeaderText = "Tài khoản";
            dgvAccount.Columns[1].HeaderText = "Mật khẩu";
            dgvAccount.Columns[2].HeaderText = "Họ tên";
            dgvAccount.Columns[3].HeaderText = "Email";
            dgvAccount.Columns[4].HeaderText = "Điện thoại";
            dgvAccount.Columns[5].HeaderText = "Ngày tạo";
        }
    }
}
