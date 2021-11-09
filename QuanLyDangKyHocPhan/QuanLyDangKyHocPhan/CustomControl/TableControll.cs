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

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class TableControll : UserControl
    {
        public TableControll()
        {
            InitializeComponent();
        }

        private void TableControll_Load(object sender, EventArgs e)
        {

        }

        private void TableControll_Click(object sender, EventArgs e)
        {
            if (btnValid.Visible == false)
            {
                btnValid.Visible = true;
            }
            else
            {
                this.Enabled = true;
            }
        }

        public void LoadTableName(string tableName)
        {
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
