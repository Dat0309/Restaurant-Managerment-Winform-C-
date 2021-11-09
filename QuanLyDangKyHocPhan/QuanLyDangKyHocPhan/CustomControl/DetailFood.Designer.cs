namespace QuanLyDangKyHocPhan.CustomControl
{
    partial class DetailFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lbNameFood = new Guna.UI.WinForms.GunaLabel();
            this.btnValid = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.lbPrice);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(3, 5);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 5;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(94, 23);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(24, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(42, 20);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "price";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.Controls.Add(this.lbNameFood);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(3, 37);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 55;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(207, 46);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // lbNameFood
            // 
            this.lbNameFood.AutoSize = true;
            this.lbNameFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFood.Location = new System.Drawing.Point(11, 14);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(86, 20);
            this.lbNameFood.TabIndex = 0;
            this.lbNameFood.Text = "NameFood";
            // 
            // btnValid
            // 
            this.btnValid.AnimationHoverSpeed = 0.07F;
            this.btnValid.AnimationSpeed = 0.03F;
            this.btnValid.BackColor = System.Drawing.Color.Transparent;
            this.btnValid.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnValid.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnValid.BorderColor = System.Drawing.Color.Black;
            this.btnValid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnValid.FocusedColor = System.Drawing.Color.Empty;
            this.btnValid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValid.ForeColor = System.Drawing.Color.White;
            this.btnValid.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_plus_math_50px;
            this.btnValid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnValid.ImageSize = new System.Drawing.Size(32, 32);
            this.btnValid.Location = new System.Drawing.Point(3, 174);
            this.btnValid.Name = "btnValid";
            this.btnValid.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnValid.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnValid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnValid.OnHoverForeColor = System.Drawing.Color.White;
            this.btnValid.OnHoverImage = null;
            this.btnValid.OnPressedColor = System.Drawing.Color.Black;
            this.btnValid.Radius = 5;
            this.btnValid.Size = new System.Drawing.Size(45, 42);
            this.btnValid.TabIndex = 2;
            this.btnValid.Visible = false;
            // 
            // DetailFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDangKyHocPhan.Properties.Resources.humberger;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.DoubleBuffered = true;
            this.Name = "DetailFood";
            this.Size = new System.Drawing.Size(213, 219);
            this.Click += new System.EventHandler(this.DetailFood_Click);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lbNameFood;
        private Guna.UI.WinForms.GunaGradientButton btnValid;
    }
}
