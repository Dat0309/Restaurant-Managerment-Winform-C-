namespace QuanLyDangKyHocPhan
{
    partial class FrmTableBills
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbxDate = new System.Windows.Forms.ListBox();
            this.dgvTableBills = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxDate
            // 
            this.lbxDate.FormattingEnabled = true;
            this.lbxDate.ItemHeight = 16;
            this.lbxDate.Location = new System.Drawing.Point(12, 12);
            this.lbxDate.Name = "lbxDate";
            this.lbxDate.Size = new System.Drawing.Size(211, 468);
            this.lbxDate.TabIndex = 0;
            this.lbxDate.SelectedIndexChanged += new System.EventHandler(this.lbxDate_SelectedIndexChanged);
            // 
            // dgvTableBills
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTableBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTableBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvTableBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTableBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTableBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTableBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableBills.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTableBills.EnableHeadersVisualStyles = false;
            this.dgvTableBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableBills.Location = new System.Drawing.Point(229, 12);
            this.dgvTableBills.Name = "dgvTableBills";
            this.dgvTableBills.RowHeadersVisible = false;
            this.dgvTableBills.RowHeadersWidth = 51;
            this.dgvTableBills.RowTemplate.Height = 24;
            this.dgvTableBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableBills.Size = new System.Drawing.Size(685, 468);
            this.dgvTableBills.TabIndex = 1;
            this.dgvTableBills.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvTableBills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableBills.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTableBills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTableBills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTableBills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTableBills.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableBills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableBills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTableBills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTableBills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTableBills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTableBills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableBills.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTableBills.ThemeStyle.ReadOnly = false;
            this.dgvTableBills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableBills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTableBills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTableBills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTableBills.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTableBills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableBills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FrmTableBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 485);
            this.Controls.Add(this.dgvTableBills);
            this.Controls.Add(this.lbxDate);
            this.Name = "FrmTableBills";
            this.Text = "FrmTableBills";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDate;
        private Guna.UI.WinForms.GunaDataGridView dgvTableBills;
    }
}