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

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class OrderControl : UserControl
    {
        int foodId, billId, billDetailId;

        public OrderControl()
        {
            InitializeComponent();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }

        private void UpDateBillDetail(int quantity)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "EXECUTE BillDetail_Update @id,@billId,@quantity";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@billId", SqlDbType.Int);
                cmd.Parameters.Add("@quantity", SqlDbType.Int);

                cmd.Parameters["@id"].Value = billDetailId;
                cmd.Parameters["@billId"].Value = billId;
                cmd.Parameters["@quantity"].Value = quantity;

                conn.Open();

                var numEffect = cmd.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        public int GetQuantity()
        {
            return int.Parse(nmrCount.Text);
        }

        public void initUI(string title,string date, int price, int quantity, int foodId, int billId, int billDetailId)
        {
            this.billDetailId = billDetailId;
            this.foodId = foodId;
            this.billId = billId;
            lbTitle.Text = title;
            lbDate.Text = date;
            lbPrice.Text = (price*quantity).ToString();
            nmrCount.Text = quantity.ToString();
        }

        private void nmrCount_ValueChanged(object sender, EventArgs e)
        {
            UpDateBillDetail(int.Parse(nmrCount.Value.ToString()));
        }
    }
}
