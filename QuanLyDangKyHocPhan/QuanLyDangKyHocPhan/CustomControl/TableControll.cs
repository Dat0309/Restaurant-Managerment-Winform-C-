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
using static QuanLyDangKyHocPhan.TableForm;

namespace QuanLyDangKyHocPhan.CustomControl
{
    public partial class TableControll : UserControl
    {
        private string billID;
        private Tables table;
        public Load send;
        public TableControll()
        {
            InitializeComponent();
        }

        public TableControll(Load sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        private void InsertBillsTable()
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "Execute Bills_Insert @id output,@name,@tableId,@amount,@discount,@tax,@status,@date,@account";

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@tableId", SqlDbType.Int);
                cmd.Parameters.Add("@amount", SqlDbType.Int);
                cmd.Parameters.Add("@discount", SqlDbType.Float);
                cmd.Parameters.Add("@tax", SqlDbType.Float);
                cmd.Parameters.Add("@status", SqlDbType.Bit);
                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 100);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = "Hoá đơn bàn " + table.name;
                cmd.Parameters["@tableId"].Value = table.id;
                cmd.Parameters["@amount"].Value = 0;
                cmd.Parameters["@discount"].Value = 0;
                cmd.Parameters["@tax"].Value = 0;
                cmd.Parameters["@status"].Value = false;
                cmd.Parameters["@date"].Value = DateTime.Now.ToShortDateString();
                cmd.Parameters["@account"].Value = "dtdat";

                conn.Open();

                cmd.ExecuteNonQuery();
                billID = cmd.Parameters["@id"].Value.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void UpdateStatusTable(int status)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "EXECUTE TableStatus_Update @id,@status";

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@status", SqlDbType.Int);

            cmd.Parameters["@id"].Value = table.id;
            cmd.Parameters["@status"].Value = status;

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void TableControll_Load(object sender, EventArgs e)
        {

        }

        private void TableControll_Click(object sender, EventArgs e)
        {
            if (btnValid.Visible == false)
            {
                try
                {
                    if (send != null)
                    {
                        UpdateStatusTable(1);
                        InsertBillsTable();
                        btnValid.Visible = true;
                        this.send(this.table, billID);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SqlError");
                }
                
            }
            else
            {
                try
                {
                    BillForm billForm = new BillForm();
                    billForm.LoadBills(table.id);
                    //billForm.FormClosing += new FormClosingEventHandler(frmClosed);
                    if(billForm.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadStatus(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SqlError");
                }
            }
        }

        //private void frmClosed(object sender, FormClosingEventArgs e)
        //{
        //    LoadStatus(0);
        //}

        public void LoadTableName(string tableName, Tables currentTable)
        {
            this.table = currentTable;
            lbNameTable.Text = "Bàn " + tableName;
        }
        public void LoadStatus(int status)
        {
            if (status == 0)
                btnValid.Visible = false;
            else
                btnValid.Visible = true;
        }
    }
}
