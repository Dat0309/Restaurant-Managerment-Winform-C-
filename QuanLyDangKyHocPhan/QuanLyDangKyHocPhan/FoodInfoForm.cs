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
    public partial class FoodInfoForm : Form
    {
        DataTable foodTb;
        public FoodInfoForm()
        {
            InitializeComponent();
        }
        private void LoadCategory()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food Where FoodCategoryID = @categoryId";

            cmd.Parameters.Add("@categoryId", SqlDbType.Int);
            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTb = new DataTable();

            conn.Open();

            adapter.Fill(foodTb);

            conn.Close();
            conn.Dispose();

            dgvFoodList.DataSource = foodTb;

            dgvFoodList.Columns[0].ReadOnly = true;


            dgvFoodList.Columns[0].HeaderText = "Mã món ăn";
            dgvFoodList.Columns[1].HeaderText = "Tên món";
            dgvFoodList.Columns[2].HeaderText = "Đơn vị";
            dgvFoodList.Columns[3].HeaderText = "Nhóm món ăn";
            dgvFoodList.Columns[4].HeaderText = "Giá";
            dgvFoodList.Columns[5].HeaderText = "Ghi chú";
            dgvFoodList.Columns[6].HeaderText = "Hình ảnh";

            lbCatName.Text = cbbCategory.Text;
            lbQuantity.Text = foodTb.Rows.Count.ToString();
        }

        private void tsmCalculateQuantuty_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

                if (dgvFoodList.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                    DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                    cmd.Parameters.Add("@foodId", SqlDbType.Int);
                    cmd.Parameters["@foodId"].Value = rowView["ID"];

                    cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                    cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    var result = cmd.Parameters["@numSaleFood"].Value.ToString();
                    MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + (result == ""? "0" : result) + " " + rowView["Unit"]);

                    conn.Close();

                }
                cmd.Dispose();
                conn.Dispose();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SqlError");
            }
            
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodControlForm frmFood = new FoodControlForm();
            frmFood.loadAdd();
            frmFood.FormClosed += new FormClosedEventHandler(frmFood_FormClosed);
            frmFood.Show(this);
        }

        private void frmFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                var rowView = selectedRow.DataBoundItem as DataRowView;
                FoodControlForm frmFood = new FoodControlForm();
                frmFood.loadUpdate();
                frmFood.FormClosed += new FormClosedEventHandler(frmFood_FormClosed);
                frmFood.Show(this);
                frmFood.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (foodTb == null) return;

            string filterExpression = "Name like '%" + txtSearch.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState dataViewRowState = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTb, filterExpression, sortExpression, dataViewRowState);

            dgvFoodList.DataSource = foodView;
        }
    }
}
