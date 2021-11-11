namespace QuanLyDangKyHocPhan
{
    partial class BillOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBills = new Guna.UI.WinForms.GunaDataGridView();
            this.dtpDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnXuatHoaDon = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDoanhThu = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBills.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBills.EnableHeadersVisualStyles = false;
            this.dgvBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBills.Location = new System.Drawing.Point(12, 147);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(1376, 594);
            this.dgvBills.TabIndex = 10;
            this.dgvBills.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBills.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBills.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBills.ThemeStyle.ReadOnly = false;
            this.dgvBills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBills.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BaseColor = System.Drawing.Color.White;
            this.dtpDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpDate.CustomFormat = null;
            this.dtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(31, 22);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDate.Radius = 3;
            this.dtpDate.Size = new System.Drawing.Size(174, 47);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.Text = "11/11/2021";
            this.dtpDate.Value = new System.DateTime(2021, 11, 11, 8, 54, 50, 739);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.AnimationHoverSpeed = 0.07F;
            this.btnXuatHoaDon.AnimationSpeed = 0.03F;
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatHoaDon.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnXuatHoaDon.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnXuatHoaDon.BorderColor = System.Drawing.Color.Black;
            this.btnXuatHoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXuatHoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_check_file_50px_1;
            this.btnXuatHoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXuatHoaDon.Location = new System.Drawing.Point(211, 22);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnXuatHoaDon.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXuatHoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuatHoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.OnHoverImage = null;
            this.btnXuatHoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuatHoaDon.Radius = 5;
            this.btnXuatHoaDon.Size = new System.Drawing.Size(83, 47);
            this.btnXuatHoaDon.TabIndex = 15;
            this.btnXuatHoaDon.Text = "Lọc";
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.Location = new System.Drawing.Point(27, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(101, 25);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Doanh thu";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.txtDoanhThu.BaseColor = System.Drawing.Color.White;
            this.txtDoanhThu.BorderColor = System.Drawing.Color.Silver;
            this.txtDoanhThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDoanhThu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDoanhThu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoanhThu.Location = new System.Drawing.Point(134, 84);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.PasswordChar = '\0';
            this.txtDoanhThu.Radius = 3;
            this.txtDoanhThu.SelectedText = "";
            this.txtDoanhThu.Size = new System.Drawing.Size(169, 32);
            this.txtDoanhThu.TabIndex = 17;
            // 
            // BillOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 753);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvBills);
            this.Name = "BillOrderForm";
            this.Text = "BillOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvBills;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDate;
        private Guna.UI.WinForms.GunaGradientButton btnXuatHoaDon;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtDoanhThu;
    }
}