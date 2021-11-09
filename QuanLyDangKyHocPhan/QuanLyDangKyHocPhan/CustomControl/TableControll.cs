using QuanLyDangKyHocPhan.Model;
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
using static QuanLyDangKyHocPhan.TableForm;

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class TableControll : UserControl
    {
        private Tables table;
        public Load send;
        public TableControll()
        {
            InitializeComponent();
        }
        
        public TableControll(Load sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void TableControll_Load(object sender, EventArgs e)
        {

        }

        private void TableControll_Click(object sender, EventArgs e)
        {
            if (btnValid.Visible == false)
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "EXECUTE TableStatus_Update @id,@status";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@status", SqlDbType.Int);

                cmd.Parameters["@id"].Value = table.id;
                cmd.Parameters["@status"].Value = 1;

                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();

                btnValid.Visible = true;
                this.send(this.table);
            }
            else
            {
                this.Enabled = true;
            }
        }

        public void LoadTableName(string tableName, Tables currentTable)
        {
            this.table = currentTable;
            lbNameTable.Text = "Bàn " + tableName;
        }
        public void LoadStatus(int status)
        {
            if(status == 0)
                btnValid.Visible = false;
            else
                btnValid.Visible = true;
        }
    }
}
