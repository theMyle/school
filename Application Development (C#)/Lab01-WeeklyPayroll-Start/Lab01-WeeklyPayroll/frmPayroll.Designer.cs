namespace Lab01_WeeklyPayroll
{
    partial class frmPayroll
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
            this.txtExempts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriorPay = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMarital = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblPriorPay = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExempts
            // 
            this.txtExempts.Location = new System.Drawing.Point(239, 129);
            this.txtExempts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExempts.Name = "txtExempts";
            this.txtExempts.Size = new System.Drawing.Size(80, 22);
            this.txtExempts.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Number of Exemptions:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPriorPay
            // 
            this.txtPriorPay.Location = new System.Drawing.Point(239, 201);
            this.txtPriorPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriorPay.Name = "txtPriorPay";
            this.txtPriorPay.Size = new System.Drawing.Size(120, 22);
            this.txtPriorPay.TabIndex = 40;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(239, 94);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(80, 22);
            this.txtHours.TabIndex = 36;
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(239, 54);
            this.txtWage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(80, 22);
            this.txtWage.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(239, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 34;
            // 
            // txtMarital
            // 
            this.txtMarital.Location = new System.Drawing.Point(239, 165);
            this.txtMarital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarital.Name = "txtMarital";
            this.txtMarital.Size = new System.Drawing.Size(80, 22);
            this.txtMarital.TabIndex = 38;
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 17;
            this.lstResults.Location = new System.Drawing.Point(413, 15);
            this.lstResults.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(539, 208);
            this.lstResults.TabIndex = 46;
            // 
            // lblPriorPay
            // 
            this.lblPriorPay.AutoSize = true;
            this.lblPriorPay.Location = new System.Drawing.Point(43, 204);
            this.lblPriorPay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblPriorPay.Name = "lblPriorPay";
            this.lblPriorPay.Size = new System.Drawing.Size(169, 16);
            this.lblPriorPay.TabIndex = 42;
            this.lblPriorPay.Text = "Total pay prior to this week:";
            this.lblPriorPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.Location = new System.Drawing.Point(-3, 144);
            this.lblMaritalStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(228, 65);
            this.lblMaritalStatus.TabIndex = 41;
            this.lblMaritalStatus.Text = "Marital Status (M or S):";
            this.lblMaritalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(57, 94);
            this.lblHours.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(155, 16);
            this.lblHours.TabIndex = 39;
            this.lblHours.Text = "Number of hours worked:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(133, 54);
            this.lblWage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(85, 16);
            this.lblWage.TabIndex = 37;
            this.lblWage.Text = "Hourly wage:";
            this.lblWage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(116, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 16);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Employee name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(777, 270);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(176, 39);
            this.btnQuit.TabIndex = 45;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(565, 270);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(176, 39);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "Next Employee";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(209, 270);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(176, 39);
            this.btnDisplay.TabIndex = 43;
            this.btnDisplay.Text = "Display Payroll";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 326);
            this.Controls.Add(this.txtExempts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriorPay);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMarital);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lblPriorPay);
            this.Controls.Add(this.lblMaritalStatus);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPayroll";
            this.Text = "Weekly Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtExempts;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtPriorPay;
        internal System.Windows.Forms.TextBox txtHours;
        internal System.Windows.Forms.TextBox txtWage;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtMarital;
        internal System.Windows.Forms.ListBox lstResults;
        internal System.Windows.Forms.Label lblPriorPay;
        internal System.Windows.Forms.Label lblMaritalStatus;
        internal System.Windows.Forms.Label lblHours;
        internal System.Windows.Forms.Label lblWage;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnDisplay;
    }
}

