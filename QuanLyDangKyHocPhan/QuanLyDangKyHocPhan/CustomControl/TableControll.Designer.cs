namespace QuanLyDangKyHocPhan.CustomControl
{
    partial class TableControll
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lbNameTable = new Guna.UI.WinForms.GunaLabel();
            this.btnValid = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gunaShadowPanel1.Controls.Add(this.lbNameTable);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(2, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 55;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(217, 46);
            this.gunaShadowPanel1.TabIndex = 4;
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.Location = new System.Drawing.Point(60, 11);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(100, 23);
            this.lbNameTable.TabIndex = 0;
            this.lbNameTable.Text = "NameTable";
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
            this.btnValid.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_user_50px;
            this.btnValid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnValid.ImageSize = new System.Drawing.Size(32, 32);
            this.btnValid.Location = new System.Drawing.Point(3, 171);
            this.btnValid.Name = "btnValid";
            this.btnValid.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnValid.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnValid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnValid.OnHoverForeColor = System.Drawing.Color.White;
            this.btnValid.OnHoverImage = null;
            this.btnValid.OnPressedColor = System.Drawing.Color.Black;
            this.btnValid.Radius = 5;
            this.btnValid.Size = new System.Drawing.Size(45, 42);
            this.btnValid.TabIndex = 5;
            this.btnValid.Visible = false;
            // 
            // TableControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDangKyHocPhan.Properties.Resources.woodcroft_bleached_pine_rectangular_dining_table_tn7225_4f_1511;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btnValid);
            this.Name = "TableControll";
            this.Size = new System.Drawing.Size(222, 216);
            this.Load += new System.EventHandler(this.TableControll_Load);
            this.Click += new System.EventHandler(this.TableControll_Click);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lbNameTable;
        private Guna.UI.WinForms.GunaGradientButton btnValid;
    }
}
