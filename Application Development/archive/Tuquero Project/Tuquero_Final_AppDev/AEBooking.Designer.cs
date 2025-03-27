namespace Tuquero_Final_AppDev
{
    partial class frmAddBook
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
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEventName = new TextBox();
            cboEventType = new ComboBox();
            dtpStart = new DateTimePicker();
            txtNumGuest = new TextBox();
            txtDescript = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtCusName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblheader = new Label();
            lblTitle = new Label();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 223);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 3;
            label5.Text = "Event Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 272);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 4;
            label1.Text = "Event Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 320);
            label2.Name = "label2";
            label2.Size = new Size(193, 23);
            label2.TabIndex = 5;
            label2.Text = "Start Date and Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 369);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 6;
            label3.Text = "Number of Guests:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 420);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 7;
            label4.Text = "Description:";
            // 
            // txtEventName
            // 
            txtEventName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(160, 268);
            txtEventName.Margin = new Padding(3, 4, 3, 4);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(314, 30);
            txtEventName.TabIndex = 8;
            // 
            // cboEventType
            // 
            cboEventType.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEventType.FormattingEnabled = true;
            cboEventType.Location = new Point(160, 217);
            cboEventType.Margin = new Padding(3, 4, 3, 4);
            cboEventType.Name = "cboEventType";
            cboEventType.Size = new Size(314, 32);
            cboEventType.TabIndex = 9;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "MM/dd/yyyy | hh:mm tt";
            dtpStart.Font = new Font("Arial", 12F);
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(222, 312);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.MinDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(374, 30);
            dtpStart.TabIndex = 11;
            dtpStart.Value = new DateTime(2024, 12, 17, 15, 38, 54, 0);
            // 
            // txtNumGuest
            // 
            txtNumGuest.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumGuest.Location = new Point(222, 366);
            txtNumGuest.Margin = new Padding(3, 4, 3, 4);
            txtNumGuest.Name = "txtNumGuest";
            txtNumGuest.Size = new Size(99, 30);
            txtNumGuest.TabIndex = 14;
            // 
            // txtDescript
            // 
            txtDescript.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescript.Location = new Point(160, 416);
            txtDescript.Margin = new Padding(3, 4, 3, 4);
            txtDescript.Name = "txtDescript";
            txtDescript.Size = new Size(314, 30);
            txtDescript.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(213, 240, 193);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 163);
            label7.Name = "label7";
            label7.Size = new Size(287, 32);
            label7.TabIndex = 16;
            label7.Text = "Booking Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(213, 240, 193);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(42, 499);
            label8.Name = "label8";
            label8.Size = new Size(306, 32);
            label8.TabIndex = 17;
            label8.Text = "Customer Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 555);
            label9.Name = "label9";
            label9.Size = new Size(67, 23);
            label9.TabIndex = 18;
            label9.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 605);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 19;
            label10.Text = "Address:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(42, 653);
            label11.Name = "label11";
            label11.Size = new Size(158, 23);
            label11.TabIndex = 20;
            label11.Text = "Contact Number:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(42, 703);
            label12.Name = "label12";
            label12.Size = new Size(64, 23);
            label12.TabIndex = 21;
            label12.Text = "Email:";
            // 
            // txtCusName
            // 
            txtCusName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusName.Location = new Point(111, 551);
            txtCusName.Margin = new Padding(3, 4, 3, 4);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(382, 30);
            txtCusName.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(130, 601);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(363, 30);
            txtAddress.TabIndex = 23;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(192, 649);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(301, 30);
            txtContact.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(109, 699);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 30);
            txtEmail.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 247, 201);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(723, 69);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 44);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 247, 201);
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(815, 69);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 44);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblheader
            // 
            lblheader.BackColor = Color.FromArgb(128, 188, 189);
            lblheader.Dock = DockStyle.Top;
            lblheader.Location = new Point(0, 0);
            lblheader.Margin = new Padding(5, 0, 5, 0);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(949, 53);
            lblheader.TabIndex = 28;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(170, 217, 187);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Forte", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 53);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 16, 0, 0);
            lblTitle.Size = new Size(949, 75);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Add Booking";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(128, 188, 189);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_square;
            btnClose.Location = new Point(903, 1);
            btnClose.Margin = new Padding(5, 4, 5, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 49);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 30;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 240, 193);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(949, 769);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblheader);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtCusName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDescript);
            Controls.Add(txtNumGuest);
            Controls.Add(dtpStart);
            Controls.Add(cboEventType);
            Controls.Add(txtEventName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddBook";
            Text = "Add Booking";
            Load += frmAddBook_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEventName;
        private ComboBox cboEventType;
        private DateTimePicker dtpStart;
        private TextBox txtNumGuest;
        private TextBox txtDescript;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtCusName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
        private Label lblheader;
        private Label lblTitle;
        private PictureBox btnClose;
    }
}