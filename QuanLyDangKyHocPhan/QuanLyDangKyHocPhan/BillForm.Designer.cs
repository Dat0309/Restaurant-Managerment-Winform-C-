namespace QuanLyDangKyHocPhan
{
    partial class BillForm
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
            this.btnTransfer = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSynchro = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPay = new Guna.UI.WinForms.GunaGradientButton();
            this.pnBills = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtAmount = new Guna.UI.WinForms.GunaTextBox();
            this.txtDiscount = new Guna.UI.WinForms.GunaTextBox();
            this.txtTax = new Guna.UI.WinForms.GunaTextBox();
            this.lbSumPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.pnBills.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBills.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBills.EnableHeadersVisualStyles = false;
            this.dgvBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvBills.Location = new System.Drawing.Point(12, 51);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(1102, 243);
            this.dgvBills.TabIndex = 0;
            this.dgvBills.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBills.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvBills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvBills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBills.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBills.ThemeStyle.ReadOnly = false;
            this.dgvBills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvBills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBills.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvBills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBills.Click += new System.EventHandler(this.dgvBills_Click);
            this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.AnimationHoverSpeed = 0.07F;
            this.btnTransfer.AnimationSpeed = 0.03F;
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BaseColor1 = System.Drawing.Color.DarkRed;
            this.btnTransfer.BaseColor2 = System.Drawing.Color.IndianRed;
            this.btnTransfer.BorderColor = System.Drawing.Color.Black;
            this.btnTransfer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransfer.FocusedColor = System.Drawing.Color.Empty;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_add_dollar_50px1;
            this.btnTransfer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTransfer.Location = new System.Drawing.Point(654, 413);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.OnHoverBaseColor1 = System.Drawing.Color.DarkRed;
            this.btnTransfer.OnHoverBaseColor2 = System.Drawing.Color.IndianRed;
            this.btnTransfer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTransfer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTransfer.OnHoverImage = null;
            this.btnTransfer.OnPressedColor = System.Drawing.Color.Black;
            this.btnTransfer.Radius = 5;
            this.btnTransfer.Size = new System.Drawing.Size(160, 53);
            this.btnTransfer.TabIndex = 13;
            this.btnTransfer.Text = "Chuyển bàn";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnSynchro
            // 
            this.btnSynchro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSynchro.AnimationHoverSpeed = 0.07F;
            this.btnSynchro.AnimationSpeed = 0.03F;
            this.btnSynchro.BackColor = System.Drawing.Color.Transparent;
            this.btnSynchro.BaseColor1 = System.Drawing.Color.Teal;
            this.btnSynchro.BaseColor2 = System.Drawing.Color.Aqua;
            this.btnSynchro.BorderColor = System.Drawing.Color.Black;
            this.btnSynchro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSynchro.FocusedColor = System.Drawing.Color.Empty;
            this.btnSynchro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSynchro.ForeColor = System.Drawing.Color.White;
            this.btnSynchro.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_add_dollar_50px1;
            this.btnSynchro.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSynchro.Location = new System.Drawing.Point(820, 413);
            this.btnSynchro.Name = "btnSynchro";
            this.btnSynchro.OnHoverBaseColor1 = System.Drawing.Color.Teal;
            this.btnSynchro.OnHoverBaseColor2 = System.Drawing.Color.Aqua;
            this.btnSynchro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSynchro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSynchro.OnHoverImage = null;
            this.btnSynchro.OnPressedColor = System.Drawing.Color.Black;
            this.btnSynchro.Radius = 5;
            this.btnSynchro.Size = new System.Drawing.Size(127, 53);
            this.btnSynchro.TabIndex = 12;
            this.btnSynchro.Text = "Gộp bàn";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BaseColor1 = System.Drawing.Color.Green;
            this.btnPay.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_add_dollar_50px1;
            this.btnPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPay.Location = new System.Drawing.Point(953, 413);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.btnPay.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Radius = 5;
            this.btnPay.Size = new System.Drawing.Size(160, 53);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pnBills
            // 
            this.pnBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBills.BackColor = System.Drawing.Color.Transparent;
            this.pnBills.BaseColor = System.Drawing.Color.White;
            this.pnBills.Controls.Add(this.txtAmount);
            this.pnBills.Controls.Add(this.txtDiscount);
            this.pnBills.Controls.Add(this.txtTax);
            this.pnBills.Controls.Add(this.lbSumPrice);
            this.pnBills.Controls.Add(this.gunaLabel9);
            this.pnBills.Controls.Add(this.gunaLabel8);
            this.pnBills.Controls.Add(this.gunaLabel7);
            this.pnBills.Controls.Add(this.gunaLabel6);
            this.pnBills.Controls.Add(this.gunaSeparator1);
            this.pnBills.Controls.Add(this.gunaLabel5);
            this.pnBills.Location = new System.Drawing.Point(12, 310);
            this.pnBills.Name = "pnBills";
            this.pnBills.ShadowColor = System.Drawing.Color.Black;
            this.pnBills.Size = new System.Drawing.Size(635, 261);
            this.pnBills.TabIndex = 14;
            // 
            // txtAmount
            // 
            this.txtAmount.BaseColor = System.Drawing.Color.White;
            this.txtAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.Location = new System.Drawing.Point(458, 196);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(160, 49);
            this.txtAmount.TabIndex = 19;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BaseColor = System.Drawing.Color.White;
            this.txtDiscount.BorderColor = System.Drawing.Color.Silver;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiscount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(122, 126);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(74, 30);
            this.txtDiscount.TabIndex = 18;
            this.txtDiscount.Text = "0";
            // 
            // txtTax
            // 
            this.txtTax.BaseColor = System.Drawing.Color.White;
            this.txtTax.BorderColor = System.Drawing.Color.Silver;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTax.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTax.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTax.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTax.Location = new System.Drawing.Point(122, 90);
            this.txtTax.Name = "txtTax";
            this.txtTax.PasswordChar = '\0';
            this.txtTax.SelectedText = "";
            this.txtTax.Size = new System.Drawing.Size(74, 30);
            this.txtTax.TabIndex = 17;
            this.txtTax.Text = "0";
            // 
            // lbSumPrice
            // 
            this.lbSumPrice.AutoSize = true;
            this.lbSumPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbSumPrice.Location = new System.Drawing.Point(141, 49);
            this.lbSumPrice.Name = "lbSumPrice";
            this.lbSumPrice.Size = new System.Drawing.Size(0, 20);
            this.lbSumPrice.TabIndex = 16;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.Location = new System.Drawing.Point(19, 172);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(100, 23);
            this.gunaLabel9.TabIndex = 15;
            this.gunaLabel9.Text = "Thành tiền:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(21, 126);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(67, 20);
            this.gunaLabel8.TabIndex = 14;
            this.gunaLabel8.Text = "Discount";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(19, 90);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(41, 20);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Thuế";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(19, 49);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(91, 20);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Tổng số tiền";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(135, 180);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(483, 10);
            this.gunaSeparator1.TabIndex = 11;
            this.gunaSeparator1.Thickness = 5;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(16, 12);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(63, 20);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Chi tiết:";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1126, 581);
            this.Controls.Add(this.pnBills);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnSynchro);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dgvBills);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.pnBills.ResumeLayout(false);
            this.pnBills.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvBills;
        private Guna.UI.WinForms.GunaGradientButton btnPay;
        private Guna.UI.WinForms.GunaGradientButton btnSynchro;
        private Guna.UI.WinForms.GunaGradientButton btnTransfer;
        private Guna.UI.WinForms.GunaShadowPanel pnBills;
        private Guna.UI.WinForms.GunaTextBox txtAmount;
        private Guna.UI.WinForms.GunaTextBox txtDiscount;
        private Guna.UI.WinForms.GunaTextBox txtTax;
        private Guna.UI.WinForms.GunaLabel lbSumPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}