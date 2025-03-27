namespace Tuquero_Final_AppDev
{
    partial class frmManageBooking
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnBook = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            DGV = new DataGridView();
            btnRefresh = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblheader = new Label();
            booking_id = new DataGridViewTextBoxColumn();
            event_type = new DataGridViewTextBoxColumn();
            event_name = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            date_time = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(170, 217, 187);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 120);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(1066, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Records";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.search1;
            btnSearch.ImageAlign = ContentAlignment.TopRight;
            btnSearch.Location = new Point(904, 79);
            btnSearch.Margin = new Padding(5, 4, 5, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(117, 57);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(568, 88);
            dateTimePicker2.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(326, 35);
            dateTimePicker2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(249, 247, 201);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Arial Narrow", 14.25F);
            label4.Location = new Point(568, 55);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 29);
            label4.TabIndex = 5;
            label4.Text = "Date To:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(230, 91);
            dateTimePicker1.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(331, 35);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(249, 247, 201);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Narrow", 14.25F);
            label3.Location = new Point(230, 55);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 3;
            label3.Text = "Date From:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 88);
            comboBox1.Margin = new Padding(5, 4, 5, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 37);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(249, 247, 201);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial Narrow", 14.25F);
            label2.Location = new Point(32, 55);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 2;
            label2.Text = "Event Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 84);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Bookings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 304);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 29);
            label5.TabIndex = 2;
            label5.Text = "Active Bookings";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(249, 247, 201);
            btnBook.BackgroundImageLayout = ImageLayout.None;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Image = Properties.Resources.ebook4;
            btnBook.ImageAlign = ContentAlignment.MiddleRight;
            btnBook.Location = new Point(35, 831);
            btnBook.Margin = new Padding(5, 4, 5, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(170, 56);
            btnBook.TabIndex = 8;
            btnBook.Text = "New Booking";
            btnBook.TextAlign = ContentAlignment.MiddleLeft;
            btnBook.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(249, 247, 201);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Image = Properties.Resources.software;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(338, 831);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 56);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(249, 247, 201);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.bin;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(215, 831);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 56);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 236, 207);
            DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV.BackgroundColor = SystemColors.Control;
            DGV.BorderStyle = BorderStyle.None;
            DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(213, 240, 187);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { booking_id, event_type, event_name, customer, contact, date_time, status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(179, 236, 250);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV.DefaultCellStyle = dataGridViewCellStyle3;
            DGV.EnableHeadersVisualStyles = false;
            DGV.GridColor = SystemColors.ActiveBorder;
            DGV.Location = new Point(35, 349);
            DGV.Margin = new Padding(2, 3, 2, 3);
            DGV.MultiSelect = false;
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(214, 248, 254);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGV.RowHeadersWidth = 51;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Size = new Size(1419, 469);
            DGV.TabIndex = 12;
            DGV.CellClick += DGV_CellClick;
            DGV.CellContentClick += DGV_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.BackgroundImage = Properties.Resources.refresh;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlText;
            btnRefresh.Location = new Point(1403, 284);
            btnRefresh.Margin = new Padding(5, 4, 5, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(53, 59);
            btnRefresh.TabIndex = 13;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(249, 247, 201);
            pictureBox1.BackgroundImage = Properties.Resources.close;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.checklist;
            pictureBox1.Location = new Point(11, 1);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(249, 247, 201);
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.close;
            pictureBox2.Location = new Point(1456, 1);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblheader
            // 
            lblheader.BackColor = Color.FromArgb(249, 247, 201);
            lblheader.Dock = DockStyle.Top;
            lblheader.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblheader.Location = new Point(0, 0);
            lblheader.Margin = new Padding(2, 0, 2, 0);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(1498, 51);
            lblheader.TabIndex = 14;
            lblheader.Text = "          BOOKING LIST";
            lblheader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // booking_id
            // 
            booking_id.DataPropertyName = "booking_id";
            booking_id.HeaderText = "BOOKING CODE";
            booking_id.MinimumWidth = 6;
            booking_id.Name = "booking_id";
            booking_id.ReadOnly = true;
            booking_id.Width = 150;
            // 
            // event_type
            // 
            event_type.DataPropertyName = "event_type";
            event_type.HeaderText = "EVENT TYPE";
            event_type.MinimumWidth = 6;
            event_type.Name = "event_type";
            event_type.ReadOnly = true;
            event_type.Width = 150;
            // 
            // event_name
            // 
            event_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            event_name.DataPropertyName = "event_name";
            event_name.HeaderText = "EVENT NAME";
            event_name.MinimumWidth = 6;
            event_name.Name = "event_name";
            event_name.ReadOnly = true;
            // 
            // customer
            // 
            customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customer.DataPropertyName = "customer_name";
            customer.HeaderText = "CUSTOMER";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            customer.ReadOnly = true;
            customer.Width = 138;
            // 
            // contact
            // 
            contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            contact.DataPropertyName = "contact_number";
            contact.HeaderText = "CONTACT#";
            contact.MinimumWidth = 6;
            contact.Name = "contact";
            contact.ReadOnly = true;
            contact.Width = 132;
            // 
            // date_time
            // 
            date_time.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            date_time.DataPropertyName = "start_date";
            date_time.FillWeight = 300F;
            date_time.HeaderText = "DATE and TIME";
            date_time.MinimumWidth = 6;
            date_time.Name = "date_time";
            date_time.ReadOnly = true;
            date_time.Width = 116;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "STATUS";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
            // 
            // frmManageBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1498, 909);
            Controls.Add(btnDelete);
            Controls.Add(btnBook);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblheader);
            Controls.Add(btnRefresh);
            Controls.Add(DGV);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmManageBooking";
            Text = "Booking List";
            Load += frmManageBooking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Button btnBook;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView DGV;
        private Button btnRefresh;
        private Button btnSearch;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblheader;
        private DataGridViewTextBoxColumn booking_id;
        private DataGridViewTextBoxColumn event_type;
        private DataGridViewTextBoxColumn event_name;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn date_time;
        private DataGridViewTextBoxColumn status;
    }
}
