namespace Lab03_Desamparo
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtOwner = new TextBox();
            TxtLotSize = new TextBox();
            TxtLotSold = new TextBox();
            TxtLotPrice = new TextBox();
            label6 = new Label();
            BtnDisplayCost = new Button();
            label7 = new Label();
            TxtCost = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 22);
            label1.Name = "label1";
            label1.Size = new Size(255, 40);
            label1.TabIndex = 0;
            label1.Text = "Lot Calculator App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 90);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 1;
            label2.Text = "Lot Owner:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 122);
            label3.Name = "label3";
            label3.Size = new Size(146, 18);
            label3.TabIndex = 2;
            label3.Text = "Total Lot Size (sqm):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 151);
            label4.Name = "label4";
            label4.Size = new Size(106, 18);
            label4.TabIndex = 3;
            label4.Text = "Lot Sold (sqm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 180);
            label5.Name = "label5";
            label5.Size = new Size(141, 18);
            label5.TabIndex = 4;
            label5.Text = "Lot Price Per (sqm):";
            // 
            // TxtOwner
            // 
            TxtOwner.Location = new Point(204, 88);
            TxtOwner.Name = "TxtOwner";
            TxtOwner.Size = new Size(173, 23);
            TxtOwner.TabIndex = 5;
            // 
            // TxtLotSize
            // 
            TxtLotSize.Location = new Point(204, 117);
            TxtLotSize.Name = "TxtLotSize";
            TxtLotSize.Size = new Size(99, 23);
            TxtLotSize.TabIndex = 5;
            TxtLotSize.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtLotSold
            // 
            TxtLotSold.Location = new Point(204, 146);
            TxtLotSold.Name = "TxtLotSold";
            TxtLotSold.Size = new Size(99, 23);
            TxtLotSold.TabIndex = 5;
            TxtLotSold.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtLotPrice
            // 
            TxtLotPrice.Location = new Point(204, 175);
            TxtLotPrice.Name = "TxtLotPrice";
            TxtLotPrice.Size = new Size(99, 23);
            TxtLotPrice.TabIndex = 5;
            TxtLotPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(309, 151);
            label6.Name = "label6";
            label6.Size = new Size(21, 18);
            label6.TabIndex = 6;
            label6.Text = "%";
            // 
            // BtnDisplayCost
            // 
            BtnDisplayCost.Location = new Point(204, 204);
            BtnDisplayCost.Name = "BtnDisplayCost";
            BtnDisplayCost.Size = new Size(99, 34);
            BtnDisplayCost.TabIndex = 7;
            BtnDisplayCost.Text = "Display Cost";
            BtnDisplayCost.UseVisualStyleBackColor = true;
            BtnDisplayCost.Click += BtnDisplayCost_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(41, 260);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 8;
            label7.Text = "Cost:";
            // 
            // TxtCost
            // 
            TxtCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCost.Location = new Point(204, 252);
            TxtCost.Name = "TxtCost";
            TxtCost.Size = new Size(173, 33);
            TxtCost.TabIndex = 9;
            TxtCost.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 319);
            Controls.Add(TxtCost);
            Controls.Add(label7);
            Controls.Add(BtnDisplayCost);
            Controls.Add(label6);
            Controls.Add(TxtLotPrice);
            Controls.Add(TxtLotSold);
            Controls.Add(TxtLotSize);
            Controls.Add(TxtOwner);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Department of Public Works and Highways";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtOwner;
        private TextBox TxtLotSize;
        private TextBox TxtLotSold;
        private TextBox TxtLotPrice;
        private Label label6;
        private Button BtnDisplayCost;
        private Label label7;
        private TextBox TxtCost;
    }
}