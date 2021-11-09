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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListTable_Click(object sender, EventArgs e)
        {

            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM [Table]";
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new CustomControl.TableControll();
                item.LoadTableName((string)reader["Name"]);
                item.LoadStatus((int)reader["Status"]);

                flpFoodList.Controls.Add(item);
            }

            conn.Close();

        }
    }
}
