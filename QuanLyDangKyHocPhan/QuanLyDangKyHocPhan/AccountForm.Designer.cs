namespace QuanLyDangKyHocPhan
{
    partial class AccountForm
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dgvAccount = new Guna.UI.WinForms.GunaDataGridView();
            this.txtAccountName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(71, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tài khoản";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(12, 47);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mật khẩu";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(9, 84);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Họ và tên";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(458, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(46, 20);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Email";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(458, 47);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(78, 20);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Điện thoại";
            // 
            // dgvAccount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvAccount.Location = new System.Drawing.Point(12, 124);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(892, 418);
            this.dgvAccount.TabIndex = 5;
            this.dgvAccount.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAccount.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAccount.ThemeStyle.ReadOnly = false;
            this.dgvAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAccount.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgvAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAccount.Click += new System.EventHandler(this.dgvAccount_Click);
            this.dgvAccount.DoubleClick += new System.EventHandler(this.dgvAccount_DoubleClick);
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.Color.Transparent;
            this.txtAccountName.BaseColor = System.Drawing.Color.White;
            this.txtAccountName.BorderColor = System.Drawing.Color.Silver;
            this.txtAccountName.BorderSize = 1;
            this.txtAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAccountName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAccountName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccountName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountName.Location = new System.Drawing.Point(89, 6);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.PasswordChar = '\0';
            this.txtAccountName.Radius = 3;
            this.txtAccountName.SelectedText = "";
            this.txtAccountName.Size = new System.Drawing.Size(350, 32);
            this.txtAccountName.TabIndex = 8;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.Silver;
            this.txtPass.BorderSize = 1;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.Location = new System.Drawing.Point(89, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Radius = 3;
            this.txtPass.ReadOnly = true;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(350, 32);
            this.txtPass.TabIndex = 9;
            this.txtPass.Text = "123456";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BaseColor = System.Drawing.Color.White;
            this.txtFullName.BorderColor = System.Drawing.Color.Silver;
            this.txtFullName.BorderSize = 1;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFullName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFullName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(89, 78);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.Radius = 3;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(350, 32);
            this.txtFullName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(549, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 3;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(320, 32);
            this.txtEmail.TabIndex = 11;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(549, 47);
            this.mtbPhone.Mask = "0000.000.000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(320, 22);
            this.mtbPhone.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Teal;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_table_properties_50px1;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(606, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 3;
            this.btnUpdate.Size = new System.Drawing.Size(142, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Teal;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_plus_math_50px1;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(462, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 3;
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.Teal;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_table_properties_50px1;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(772, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 3;
            this.btnReset.Size = new System.Drawing.Size(124, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDataGridView dgvAccount;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtAccountName;
        private Guna.UI.WinForms.GunaTextBox txtPass;
        private Guna.UI.WinForms.GunaTextBox txtFullName;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private Guna.UI.WinForms.GunaButton btnReset;
    }
}