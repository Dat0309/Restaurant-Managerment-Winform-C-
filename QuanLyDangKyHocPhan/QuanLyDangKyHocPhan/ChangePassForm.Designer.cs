namespace QuanLyDangKyHocPhan
{
    partial class ChangePassForm
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtCurPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtNewPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtReNewPass = new Guna.UI.WinForms.GunaTextBox();
            this.btnAccept = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(25, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mật khẩu hiện tại";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(25, 55);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(100, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mật khẩu mới";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(25, 93);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(134, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Xác nhận mật khẩu";
            // 
            // txtCurPass
            // 
            this.txtCurPass.BackColor = System.Drawing.Color.Transparent;
            this.txtCurPass.BaseColor = System.Drawing.Color.White;
            this.txtCurPass.BorderColor = System.Drawing.Color.Silver;
            this.txtCurPass.BorderSize = 1;
            this.txtCurPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCurPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCurPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCurPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurPass.Location = new System.Drawing.Point(182, 17);
            this.txtCurPass.Name = "txtCurPass";
            this.txtCurPass.PasswordChar = '\0';
            this.txtCurPass.Radius = 3;
            this.txtCurPass.SelectedText = "";
            this.txtCurPass.Size = new System.Drawing.Size(322, 32);
            this.txtCurPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPass.BaseColor = System.Drawing.Color.White;
            this.txtNewPass.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPass.Location = new System.Drawing.Point(182, 55);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.Radius = 3;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(322, 32);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtReNewPass.BaseColor = System.Drawing.Color.White;
            this.txtReNewPass.BorderColor = System.Drawing.Color.Silver;
            this.txtReNewPass.BorderSize = 1;
            this.txtReNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReNewPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReNewPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReNewPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReNewPass.Location = new System.Drawing.Point(182, 93);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '\0';
            this.txtReNewPass.Radius = 3;
            this.txtReNewPass.SelectedText = "";
            this.txtReNewPass.Size = new System.Drawing.Size(322, 32);
            this.txtReNewPass.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.AnimationHoverSpeed = 0.07F;
            this.btnAccept.AnimationSpeed = 0.03F;
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAccept.BorderColor = System.Drawing.Color.Black;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccept.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Image = null;
            this.btnAccept.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccept.Location = new System.Drawing.Point(387, 140);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAccept.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccept.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccept.OnHoverImage = null;
            this.btnAccept.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccept.Radius = 5;
            this.btnAccept.Size = new System.Drawing.Size(117, 47);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 197);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtReNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurPass);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "ChangePassForm";
            this.Text = "ChangePassForm";
            this.Load += new System.EventHandler(this.ChangePassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtCurPass;
        private Guna.UI.WinForms.GunaTextBox txtNewPass;
        private Guna.UI.WinForms.GunaTextBox txtReNewPass;
        private Guna.UI.WinForms.GunaButton btnAccept;
    }
}