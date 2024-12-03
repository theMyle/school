namespace SaleCoSystem
{
    partial class frmProductList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            lblheader = new Label();
            lblFooter = new Label();
            label3 = new Label();
            DGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            label1 = new Label();
            cboFilter = new ComboBox();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnNew = new Button();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // lblheader
            // 
            lblheader.BackColor = Color.FromArgb(8, 34, 47);
            lblheader.Dock = DockStyle.Top;
            lblheader.Location = new Point(0, 0);
            lblheader.Margin = new Padding(2, 0, 2, 0);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(1213, 30);
            lblheader.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.FromArgb(8, 34, 47);
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Location = new Point(0, 569);
            lblFooter.Margin = new Padding(2, 0, 2, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1213, 4);
            lblFooter.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(8, 34, 47);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(41, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 2;
            label3.Text = "PRODUCT LIST";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(254, 236, 207);
            DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            DGV.BackgroundColor = SystemColors.Control;
            DGV.BorderStyle = BorderStyle.None;
            DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(6, 84, 113);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 192, 69);
            dataGridViewCellStyle9.Padding = new Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(214, 248, 254);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(179, 236, 250);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            DGV.DefaultCellStyle = dataGridViewCellStyle12;
            DGV.EnableHeadersVisualStyles = false;
            DGV.GridColor = SystemColors.ActiveBorder;
            DGV.Location = new Point(2, 75);
            DGV.Margin = new Padding(2);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(214, 248, 254);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            DGV.RowHeadersWidth = 62;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1211, 487);
            DGV.TabIndex = 3;
            DGV.CellContentClick += DGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "p_code";
            Column1.HeaderText = "CODE";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "p_descript";
            Column2.HeaderText = "DESCRIPTION";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "p_price";
            Column3.HeaderText = "PRICE";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "p_qoh";
            Column4.HeaderText = "STOCKS";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 170;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "v_name";
            Column5.HeaderText = "VENDOR";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 185;
            // 
            // Column6
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 224, 192);
            Column6.DefaultCellStyle = dataGridViewCellStyle10;
            Column6.HeaderText = "";
            Column6.MinimumWidth = 12;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.Text = "Edit";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 70;
            // 
            // Column7
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Column7.DefaultCellStyle = dataGridViewCellStyle11;
            Column7.FillWeight = 150F;
            Column7.HeaderText = "";
            Column7.MinimumWidth = 40;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.True;
            Column7.Text = "Delete";
            Column7.ToolTipText = "Delete Product";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 4;
            label1.Text = "FILTER RECORDS";
            // 
            // cboFilter
            // 
            cboFilter.BackColor = SystemColors.Control;
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FlatStyle = FlatStyle.Flat;
            cboFilter.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboFilter.FormattingEnabled = true;
            cboFilter.ItemHeight = 31;
            cboFilter.Items.AddRange(new object[] { "Prod Code", "Description", "Vendor" });
            cboFilter.Location = new Point(178, 33);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(191, 39);
            cboFilter.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(381, 33);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(566, 39);
            txtSearch.TabIndex = 6;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(238, 238, 238);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(6, 84, 113);
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(238, 238, 238);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 212, 177);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(64, 64, 64);
            btnRefresh.Location = new Point(960, 33);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 39);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(0, 165, 166);
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(6, 84, 113);
            btnNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 165, 166);
            btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 145, 171);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.FromArgb(224, 224, 224);
            btnNew.Location = new Point(1071, 33);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(131, 39);
            btnNew.TabIndex = 10;
            btnNew.Text = "NEW PRODUCT";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(8, 34, 47);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(8, 34, 47);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_square;
            btnClose.Location = new Point(1188, 3);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewImageColumn1.HeaderText = "";
            dataGridViewImageColumn1.MinimumWidth = 8;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewImageColumn1.ToolTipText = "Delete Product";
            dataGridViewImageColumn1.Width = 50;
            // 
            // frmProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1213, 573);
            Controls.Add(btnNew);
            Controls.Add(btnRefresh);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(txtSearch);
            Controls.Add(cboFilter);
            Controls.Add(label1);
            Controls.Add(DGV);
            Controls.Add(label3);
            Controls.Add(lblFooter);
            Controls.Add(lblheader);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product List";
            Load += frmProductList_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.PictureBox btnClose;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}
