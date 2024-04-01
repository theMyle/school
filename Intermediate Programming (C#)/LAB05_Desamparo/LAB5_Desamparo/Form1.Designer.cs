namespace LAB5_Desamparo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputCustomerName = new System.Windows.Forms.TextBox();
            this.inputItemName = new System.Windows.Forms.TextBox();
            this.inputItemPrice = new System.Windows.Forms.TextBox();
            this.inputPlanMonths = new System.Windows.Forms.TextBox();
            this.inputInterest = new System.Windows.Forms.TextBox();
            this.inputDownPayment = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputInterest = new System.Windows.Forms.Label();
            this.outputTotalDue = new System.Windows.Forms.Label();
            this.outputMonthlyFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-41, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 111);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(138, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Credit Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(27, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Item Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(27, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Plan Months:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(27, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Interest:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(27, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Down Payment:";
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.inputCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCustomerName.Location = new System.Drawing.Point(185, 141);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Size = new System.Drawing.Size(261, 26);
            this.inputCustomerName.TabIndex = 4;
            // 
            // inputItemName
            // 
            this.inputItemName.BackColor = System.Drawing.SystemColors.Control;
            this.inputItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputItemName.Location = new System.Drawing.Point(185, 173);
            this.inputItemName.Name = "inputItemName";
            this.inputItemName.Size = new System.Drawing.Size(261, 26);
            this.inputItemName.TabIndex = 4;
            // 
            // inputItemPrice
            // 
            this.inputItemPrice.BackColor = System.Drawing.SystemColors.Control;
            this.inputItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputItemPrice.Location = new System.Drawing.Point(185, 210);
            this.inputItemPrice.Name = "inputItemPrice";
            this.inputItemPrice.Size = new System.Drawing.Size(190, 26);
            this.inputItemPrice.TabIndex = 4;
            this.inputItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputPlanMonths
            // 
            this.inputPlanMonths.BackColor = System.Drawing.SystemColors.Control;
            this.inputPlanMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPlanMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPlanMonths.Location = new System.Drawing.Point(185, 247);
            this.inputPlanMonths.Name = "inputPlanMonths";
            this.inputPlanMonths.Size = new System.Drawing.Size(85, 26);
            this.inputPlanMonths.TabIndex = 4;
            // 
            // inputInterest
            // 
            this.inputInterest.BackColor = System.Drawing.SystemColors.Control;
            this.inputInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputInterest.Location = new System.Drawing.Point(185, 286);
            this.inputInterest.Name = "inputInterest";
            this.inputInterest.Size = new System.Drawing.Size(85, 26);
            this.inputInterest.TabIndex = 4;
            // 
            // inputDownPayment
            // 
            this.inputDownPayment.BackColor = System.Drawing.SystemColors.Control;
            this.inputDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDownPayment.Location = new System.Drawing.Point(185, 327);
            this.inputDownPayment.Name = "inputDownPayment";
            this.inputDownPayment.Size = new System.Drawing.Size(190, 26);
            this.inputDownPayment.TabIndex = 4;
            this.inputDownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Maroon;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCompute.Location = new System.Drawing.Point(185, 359);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(124, 66);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReset.Location = new System.Drawing.Point(322, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 66);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(27, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Interest:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(27, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Due:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(27, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Monthly Fee:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB5_Desamparo.Properties.Resources.home_credit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // outputInterest
            // 
            this.outputInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.outputInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.outputInterest.Location = new System.Drawing.Point(185, 448);
            this.outputInterest.Name = "outputInterest";
            this.outputInterest.Size = new System.Drawing.Size(190, 27);
            this.outputInterest.TabIndex = 6;
            this.outputInterest.Text = "0.00";
            this.outputInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputTotalDue
            // 
            this.outputTotalDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.outputTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.outputTotalDue.Location = new System.Drawing.Point(185, 483);
            this.outputTotalDue.Name = "outputTotalDue";
            this.outputTotalDue.Size = new System.Drawing.Size(190, 27);
            this.outputTotalDue.TabIndex = 6;
            this.outputTotalDue.Text = "0.00";
            this.outputTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputMonthlyFee
            // 
            this.outputMonthlyFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.outputMonthlyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.outputMonthlyFee.Location = new System.Drawing.Point(185, 517);
            this.outputMonthlyFee.Name = "outputMonthlyFee";
            this.outputMonthlyFee.Size = new System.Drawing.Size(190, 27);
            this.outputMonthlyFee.TabIndex = 6;
            this.outputMonthlyFee.Text = "0.00";
            this.outputMonthlyFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 565);
            this.Controls.Add(this.outputMonthlyFee);
            this.Controls.Add(this.outputTotalDue);
            this.Controls.Add(this.outputInterest);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.inputDownPayment);
            this.Controls.Add(this.inputInterest);
            this.Controls.Add(this.inputPlanMonths);
            this.Controls.Add(this.inputItemPrice);
            this.Controls.Add(this.inputItemName);
            this.Controls.Add(this.inputCustomerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputCustomerName;
        private System.Windows.Forms.TextBox inputItemName;
        private System.Windows.Forms.TextBox inputItemPrice;
        private System.Windows.Forms.TextBox inputPlanMonths;
        private System.Windows.Forms.TextBox inputInterest;
        private System.Windows.Forms.TextBox inputDownPayment;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label outputInterest;
        private System.Windows.Forms.Label outputTotalDue;
        private System.Windows.Forms.Label outputMonthlyFee;
    }
}

