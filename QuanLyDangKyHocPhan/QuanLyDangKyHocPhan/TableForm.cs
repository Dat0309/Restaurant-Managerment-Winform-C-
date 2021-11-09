using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDangKyHocPhan.Model;

namespace QuanLyDangKyHocPhan
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        public void initUI(List<Tables> tables)
        {
            foreach (Tables table in tables)
            {
                var item = new CustomControl.TableControll();

                item.LoadTableName(table.name);
                item.LoadStatus(table.status);

                flpTables.Controls.Add(item);
            }
        }
    }
}
