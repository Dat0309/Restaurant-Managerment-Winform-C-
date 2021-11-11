namespace QuanLyDangKyHocPhan
{
    partial class TableInfoForm
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
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtCapacity = new Guna.UI.WinForms.GunaTextBox();
            this.cbbStatus = new Guna.UI.WinForms.GunaComboBox();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.dgvTable = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.tsmViewBills = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewMemoryBills = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(29, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tên bàn";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(29, 57);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Tình trạng";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(29, 92);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(55, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Số ghế";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderSize = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(127, 18);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 3;
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(333, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.Transparent;
            this.txtCapacity.BaseColor = System.Drawing.Color.White;
            this.txtCapacity.BorderColor = System.Drawing.Color.Silver;
            this.txtCapacity.BorderSize = 1;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCapacity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCapacity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCapacity.Location = new System.Drawing.Point(127, 91);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.Radius = 3;
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.Size = new System.Drawing.Size(333, 30);
            this.txtCapacity.TabIndex = 5;
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbbStatus.BaseColor = System.Drawing.Color.White;
            this.cbbStatus.BorderColor = System.Drawing.Color.Silver;
            this.cbbStatus.BorderSize = 1;
            this.cbbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cbbStatus.Location = new System.Drawing.Point(127, 54);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbStatus.Radius = 3;
            this.cbbStatus.Size = new System.Drawing.Size(333, 31);
            this.cbbStatus.TabIndex = 6;
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
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(33, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 3;
            this.btnAdd.Size = new System.Drawing.Size(140, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Teal;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(179, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 3;
            this.btnUpdate.Size = new System.Drawing.Size(140, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Teal;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.Enabled = false;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(325, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 3;
            this.btnDelete.Size = new System.Drawing.Size(140, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.ColumnHeadersHeight = 4;
            this.dgvTable.ContextMenuStrip = this.gunaContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTable.Location = new System.Drawing.Point(12, 187);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(885, 338);
            this.dgvTable.TabIndex = 10;
            this.dgvTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTable.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTable.ThemeStyle.ReadOnly = false;
            this.dgvTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTable.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTable.Click += new System.EventHandler(this.dgvTable_Click);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewBills,
            this.tsmViewMemoryBills});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(237, 52);
            // 
            // tsmViewBills
            // 
            this.tsmViewBills.Name = "tsmViewBills";
            this.tsmViewBills.Size = new System.Drawing.Size(236, 24);
            this.tsmViewBills.Text = "Xem danh mục hoá đơn";
            this.tsmViewBills.Click += new System.EventHandler(this.tsmViewBills_Click);
            // 
            // tsmViewMemoryBills
            // 
            this.tsmViewMemoryBills.Name = "tsmViewMemoryBills";
            this.tsmViewMemoryBills.Size = new System.Drawing.Size(236, 24);
            this.tsmViewMemoryBills.Text = "Xem nhật ký hoá đơn";
            this.tsmViewMemoryBills.Click += new System.EventHandler(this.tsmViewMemoryBills_Click);
            // 
            // TableInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 537);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "TableInfoForm";
            this.Text = "TableInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaTextBox txtCapacity;
        private Guna.UI.WinForms.GunaComboBox cbbStatus;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaDataGridView dgvTable;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmViewBills;
        private System.Windows.Forms.ToolStripMenuItem tsmViewMemoryBills;
    }
}