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
    public partial class FoodControlForm : Form
    {
        public FoodControlForm()
        {
            InitializeComponent();
        }
        public void loadAdd()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }
        public void loadUpdate()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }
        private void InitValues()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            conn.Open();

            adapter.Fill(ds, "Category");

            cbbCate.DataSource = ds.Tables["Category"];
            cbbCate.DisplayMember = "Name";
            cbbCate.ValueMember = "ID";

            conn.Close();
        }
        private void ResetText()
        {
            txtID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCate.ResetText();
            nmrPrice.ResetText();
            txtPhoto.ResetText();
        }

        private void FoodControlForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nmrPrice.Text = rowView["Notes"].ToString();
                txtPhoto.Text = rowView["Picture"].ToString();
                cbbCate.SelectedIndex = -1;

                for (int index = 0; index < cbbCate.Items.Count; index++)
                {
                    var cat = cbbCate.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCate.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string defaultPhoto = "E:\\NAM3\\Restaurant - Managerment - Winform - C -\\QuanLyDangKyHocPhan\\QuanLyDangKyHocPhan\\Resources\\food.png";
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertFood @id output, @name, @unit, @foodCategoryID, @price, @notes, @pic";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@pic", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCate.SelectedValue;
                cmd.Parameters["@price"].Value = nmrPrice.Text;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                cmd.Parameters["@pic"].Value = txtPhoto.Text == ""? defaultPhoto:txtPhoto.Text;

                conn.Open();

                int numRow = cmd.ExecuteNonQuery();

                if (numRow > 0)
                {
                    var foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Successfully adding new food. Food ID = " + foodID, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }

                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE aUpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 3000);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCate.SelectedValue;
                cmd.Parameters["@price"].Value = nmrPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                conn.Open();

                int numRow = cmd.ExecuteNonQuery();
                if (numRow > 0)
                {
                    MessageBox.Show("Successfully updateing food", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            AddCateForm frm = new AddCateForm();
            frm.FormClosed += new FormClosedEventHandler(frmCloed);
            frm.Show(this);
        }

        private void frmCloed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCate.SelectedIndex;
            cbbCate.SelectedIndex = -1;
            cbbCate.SelectedIndex = index;
            InitValues();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $"D:";
            DialogResult dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                txtPhoto.Text = fileName;
            }
        }
    }
}
