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
using static QuanLyDangKyHocPhan.Form1;

namespace QuanLyDangKyHocPhan
{
    public partial class TableForm : Form
    {
        public delegate void Load(Tables food,string billId);

        public Tables curTable;
        public SendFood send;

        public TableForm()
        {
            InitializeComponent();
        }
        
        public TableForm(SendFood sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void SetValue(Tables value, string billId)
        {
            this.curTable = value;
            this.send(curTable,billId);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void initUI(List<Tables> tables)
        {
            foreach (Tables table in tables)
            {
                var item = new CustomControl.TableControll(SetValue);

                item.LoadTableName(table.name, table);
                item.LoadStatus(table.status);

                flpTables.Controls.Add(item);
            }
        }
    }
}
