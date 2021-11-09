using QuanLyDangKyHocPhan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyDangKyHocPhan.Form1;

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class DetailFood : UserControl
    {
        public ReceiveFood send;
        private Food curFood;

        public DetailFood()
        {
            InitializeComponent();
        }
        public DetailFood(ReceiveFood sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void DetailFood_Click(object sender, EventArgs e)
        {
            if(btnValid.Visible == false)
            {
                this.send(curFood);
                btnValid.Visible = true;
            }
            else
            {
                btnValid.Visible = false;
            }
        }

        public void LoadFood(string name, int price, string img, Food food)
        {
            this.curFood = food;
            lbNameFood.Text = name;
            lbPrice.Text = price.ToString();
            this.BackgroundImage = Image.FromFile(img);
        }
    }
}
