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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }
        public void LoadRole(string name)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = $"Select RoleName, Path, Role.Notes from Role, RoleAccount where AccountName = '{name}' and ID = RoleID";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable("Role");

            conn.Open();

            adapter.Fill(table);

            dgvRole.DataSource = table;

            // Prevent user to edit ID
            dgvRole.Columns[0].ReadOnly = true;

            dgvRole.Columns[0].HeaderText = "Tên quyền";
            dgvRole.Columns[1].HeaderText = "Path";
            dgvRole.Columns[2].HeaderText = "Ghi chú";

            conn.Close();
        }
    }
}
