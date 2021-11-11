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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Execute Password_Update @account,@pass";
                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 200);

                cmd.Parameters["@account"].Value = "dttdat";
                cmd.Parameters["@pass"].Value = txtNewPass.Text;

                conn.Open();

                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Đổiỉ mật khẩu thành công");
                    this.Close();
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SqlError");
            }
            
        }
    }
}
