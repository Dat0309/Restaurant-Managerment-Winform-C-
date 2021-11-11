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
    public partial class AddCateForm : Form
    {
        public AddCateForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE Category_Insert @id output, @name, @type";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@type", SqlDbType.Int);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd.Parameters["@name"].Value = txtNameCat.Text;
                cmd.Parameters["@type"].Value = cbbType.Text;

                conn.Open();

                int numRow = cmd.ExecuteNonQuery();

                if (numRow > 0)
                {
                    var catID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Successfully adding new category. Category ID " + catID, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding category failed");
                }

                conn.Close();
                conn.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Error");
            }
        }

        private void ResetText()
        {
            txtID.ResetText();
            txtNameCat.ResetText();
            cbbType.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCateForm_Load(object sender, EventArgs e)
        {
            LoadType();
        }

        private void LoadType()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT Type From Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            conn.Close();

            cbbType.DataSource = dt;
            cbbType.DisplayMember = "Type";
        }
    }
}
