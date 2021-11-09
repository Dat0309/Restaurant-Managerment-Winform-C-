using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }

        public void initUI(string title,string date, int price, int quantity)
        {
            lbTitle.Text = title;
            lbDate.Text = date;
            lbPrice.Text = (price*quantity).ToString();
            nmrCount.Text = quantity.ToString();
        }
    }
}
