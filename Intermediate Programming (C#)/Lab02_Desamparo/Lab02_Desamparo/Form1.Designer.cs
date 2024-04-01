namespace Lab02_Desamparo
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
            lblProject = new Label();
            lblQuiz = new Label();
            lblExam = new Label();
            lblFinalExam = new Label();
            lblWA = new Label();
            lblHomework = new Label();
            txtHomework = new TextBox();
            txtProject = new TextBox();
            txtQuiz = new TextBox();
            txtExam = new TextBox();
            txtFinalExam = new TextBox();
            txtWA = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(373, 35);
            label1.TabIndex = 0;
            label1.Text = "Grade Calculator By Kyle";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblProject.Location = new Point(26, 166);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(148, 24);
            lblProject.TabIndex = 0;
            lblProject.Text = "Project Grade:";
            // 
            // lblQuiz
            // 
            lblQuiz.AutoSize = true;
            lblQuiz.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblQuiz.Location = new Point(26, 225);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(124, 24);
            lblQuiz.TabIndex = 0;
            lblQuiz.Text = "Quiz Grade:";
            // 
            // lblExam
            // 
            lblExam.AutoSize = true;
            lblExam.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblExam.Location = new Point(26, 282);
            lblExam.Name = "lblExam";
            lblExam.Size = new Size(133, 24);
            lblExam.TabIndex = 0;
            lblExam.Text = "Exam Grade:";
            // 
            // lblFinalExam
            // 
            lblFinalExam.AutoSize = true;
            lblFinalExam.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblFinalExam.Location = new Point(26, 341);
            lblFinalExam.Name = "lblFinalExam";
            lblFinalExam.Size = new Size(184, 24);
            lblFinalExam.TabIndex = 0;
            lblFinalExam.Text = "Final Exam Grade:";
            // 
            // lblWA
            // 
            lblWA.AutoSize = true;
            lblWA.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblWA.Location = new Point(26, 469);
            lblWA.Name = "lblWA";
            lblWA.Size = new Size(187, 24);
            lblWA.TabIndex = 0;
            lblWA.Text = "Weighted Average:";
            // 
            // lblHomework
            // 
            lblHomework.AutoSize = true;
            lblHomework.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHomework.Location = new Point(26, 116);
            lblHomework.Name = "lblHomework";
            lblHomework.Size = new Size(181, 24);
            lblHomework.TabIndex = 0;
            lblHomework.Text = "Homework Grade:";
            // 
            // txtHomework
            // 
            txtHomework.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHomework.Location = new Point(242, 113);
            txtHomework.Name = "txtHomework";
            txtHomework.Size = new Size(157, 30);
            txtHomework.TabIndex = 1;
            txtHomework.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProject
            // 
            txtProject.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProject.Location = new Point(242, 163);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(157, 30);
            txtProject.TabIndex = 1;
            txtProject.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQuiz
            // 
            txtQuiz.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuiz.Location = new Point(242, 222);
            txtQuiz.Name = "txtQuiz";
            txtQuiz.Size = new Size(157, 30);
            txtQuiz.TabIndex = 1;
            txtQuiz.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExam
            // 
            txtExam.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExam.Location = new Point(242, 279);
            txtExam.Name = "txtExam";
            txtExam.Size = new Size(157, 30);
            txtExam.TabIndex = 1;
            txtExam.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFinalExam
            // 
            txtFinalExam.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFinalExam.Location = new Point(242, 338);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(157, 30);
            txtFinalExam.TabIndex = 1;
            txtFinalExam.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWA
            // 
            txtWA.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWA.Location = new Point(242, 466);
            txtWA.Name = "txtWA";
            txtWA.ReadOnly = true;
            txtWA.Size = new Size(157, 30);
            txtWA.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(76, 405);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 2;
            button1.Text = "COMPUTE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(242, 405);
            button2.Name = "button2";
            button2.Size = new Size(131, 29);
            button2.TabIndex = 3;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 546);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtWA);
            Controls.Add(txtFinalExam);
            Controls.Add(txtExam);
            Controls.Add(txtQuiz);
            Controls.Add(txtProject);
            Controls.Add(txtHomework);
            Controls.Add(lblHomework);
            Controls.Add(lblWA);
            Controls.Add(lblFinalExam);
            Controls.Add(lblExam);
            Controls.Add(lblQuiz);
            Controls.Add(lblProject);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblProject;
        private Label lblQuiz;
        private Label lblExam;
        private Label lblFinalExam;
        private Label lblWA;
        private Label lblHomework;
        private TextBox txtHomework;
        private TextBox txtProject;
        private TextBox txtQuiz;
        private TextBox txtExam;
        private TextBox txtFinalExam;
        private TextBox txtWA;
        private Button button1;
        private Button button2;
    }
}
