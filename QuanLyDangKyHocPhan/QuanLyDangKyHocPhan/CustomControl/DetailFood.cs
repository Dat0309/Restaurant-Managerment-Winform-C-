﻿using System;
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
    public partial class DetailFood : UserControl
    {
        public DetailFood()
        {
            InitializeComponent();
        }

        private void DetailFood_Click(object sender, EventArgs e)
        {
            if(btnValid.Visible == false)
            {
                btnValid.Visible = true;
            }
            else
            {
                btnValid.Visible = false;
            }
        }
    }
}