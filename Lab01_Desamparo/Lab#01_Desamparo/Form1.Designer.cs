namespace Lab_01_Desamparo
{
    partial class frmNewStudent
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
            lblLastName = new Label();
            lblFirstName = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            lblStatus = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblLastName.Location = new Point(37, 57);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(117, 24);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblFirstName.Location = new Point(35, 112);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(119, 24);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAddress.Location = new Point(59, 161);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(95, 24);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(86, 328);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 24);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.LightGreen;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Arial", 15F);
            lblStatus.Location = new Point(177, 475);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(30, 20, 30, 20);
            lblStatus.Size = new Size(306, 70);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "New Student Added!";
            lblStatus.Visible = false;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(174, 54);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(309, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(174, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(309, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(174, 161);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(309, 131);
            txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(174, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Arial Narrow", 12F);
            btnOk.Location = new Point(174, 381);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(132, 65);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Narrow", 12F);
            btnCancel.Location = new Point(350, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 65);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // frmNewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(538, 580);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblStatus);
            Controls.Add(lblEmail);
            Controls.Add(lblAddress);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Name = "frmNewStudent";
            Text = "Text Student";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLastName;
        private Label lblFirstName;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblStatus;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Button btnOk;
        private Button btnCancel;
    }
}
