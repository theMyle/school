namespace Lab04_Desamparo
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
            label6 = new Label();
            label7 = new Label();
            CustomerNameTxtBox = new TextBox();
            HoursOfLaborTxtBox = new TextBox();
            CostOfPartsTxtBox = new TextBox();
            LaborCostTxtBox = new TextBox();
            PartsCostTxtBox = new TextBox();
            TotalCostTxtBox = new TextBox();
            DisplayBillBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(293, 37);
            label1.TabIndex = 0;
            label1.Text = "Service Calculator App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 77);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 0;
            label2.Text = "Customer Name: ";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 114);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 0;
            label3.Text = "Hours of Labor: ";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 154);
            label4.Name = "label4";
            label4.Size = new Size(148, 17);
            label4.TabIndex = 0;
            label4.Text = "Cost of Parts/Supplies: ";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(75, 290);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 0;
            label5.Text = "Labor Cost: ";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(75, 369);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 0;
            label6.Text = "Total Cost: ";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(75, 331);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 0;
            label7.Text = "Parts Cost: ";
            label7.Click += label1_Click;
            // 
            // CustomerNameTxtBox
            // 
            CustomerNameTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerNameTxtBox.Location = new Point(194, 74);
            CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            CustomerNameTxtBox.Size = new Size(199, 25);
            CustomerNameTxtBox.TabIndex = 1;
            // 
            // HoursOfLaborTxtBox
            // 
            HoursOfLaborTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HoursOfLaborTxtBox.Location = new Point(194, 106);
            HoursOfLaborTxtBox.Name = "HoursOfLaborTxtBox";
            HoursOfLaborTxtBox.Size = new Size(114, 25);
            HoursOfLaborTxtBox.TabIndex = 1;
            HoursOfLaborTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CostOfPartsTxtBox
            // 
            CostOfPartsTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CostOfPartsTxtBox.Location = new Point(193, 146);
            CostOfPartsTxtBox.Name = "CostOfPartsTxtBox";
            CostOfPartsTxtBox.Size = new Size(114, 25);
            CostOfPartsTxtBox.TabIndex = 1;
            CostOfPartsTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // LaborCostTxtBox
            // 
            LaborCostTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LaborCostTxtBox.Location = new Point(194, 282);
            LaborCostTxtBox.Name = "LaborCostTxtBox";
            LaborCostTxtBox.ReadOnly = true;
            LaborCostTxtBox.Size = new Size(114, 25);
            LaborCostTxtBox.TabIndex = 1;
            LaborCostTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PartsCostTxtBox
            // 
            PartsCostTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PartsCostTxtBox.Location = new Point(194, 323);
            PartsCostTxtBox.Name = "PartsCostTxtBox";
            PartsCostTxtBox.ReadOnly = true;
            PartsCostTxtBox.Size = new Size(114, 25);
            PartsCostTxtBox.TabIndex = 1;
            PartsCostTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // TotalCostTxtBox
            // 
            TotalCostTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCostTxtBox.Location = new Point(194, 361);
            TotalCostTxtBox.Name = "TotalCostTxtBox";
            TotalCostTxtBox.ReadOnly = true;
            TotalCostTxtBox.Size = new Size(114, 25);
            TotalCostTxtBox.TabIndex = 1;
            TotalCostTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // DisplayBillBtn
            // 
            DisplayBillBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayBillBtn.Location = new Point(193, 177);
            DisplayBillBtn.Name = "DisplayBillBtn";
            DisplayBillBtn.Size = new Size(115, 42);
            DisplayBillBtn.TabIndex = 2;
            DisplayBillBtn.Text = "Display Bill";
            DisplayBillBtn.UseVisualStyleBackColor = true;
            DisplayBillBtn.Click += DisplayBillBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClearBtn.Location = new Point(193, 225);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(113, 37);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 510);
            Controls.Add(ClearBtn);
            Controls.Add(DisplayBillBtn);
            Controls.Add(TotalCostTxtBox);
            Controls.Add(PartsCostTxtBox);
            Controls.Add(LaborCostTxtBox);
            Controls.Add(CostOfPartsTxtBox);
            Controls.Add(HoursOfLaborTxtBox);
            Controls.Add(CustomerNameTxtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Mang Jose's Repair Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox CustomerNameTxtBox;
        private TextBox HoursOfLaborTxtBox;
        private TextBox CostOfPartsTxtBox;
        private TextBox LaborCostTxtBox;
        private TextBox PartsCostTxtBox;
        private TextBox TotalCostTxtBox;
        private Button DisplayBillBtn;
        private Button ClearBtn;
    }
}
