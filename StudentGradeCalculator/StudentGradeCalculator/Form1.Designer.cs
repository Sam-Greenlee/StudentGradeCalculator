namespace StudentGradeCalculator
{
    partial class frmStudentGradeCalculator
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetStudents = new System.Windows.Forms.Button();
            this.btnGetQuizzes = new System.Windows.Forms.Button();
            this.lstQuizzes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Location = new System.Drawing.Point(32, 47);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(343, 372);
            this.lstStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // btnGetStudents
            // 
            this.btnGetStudents.Location = new System.Drawing.Point(490, 24);
            this.btnGetStudents.Name = "btnGetStudents";
            this.btnGetStudents.Size = new System.Drawing.Size(258, 23);
            this.btnGetStudents.TabIndex = 2;
            this.btnGetStudents.Text = "Get Students from Students.txt";
            this.btnGetStudents.UseVisualStyleBackColor = true;
            this.btnGetStudents.Click += new System.EventHandler(this.btnGetStudents_Click);
            // 
            // btnGetQuizzes
            // 
            this.btnGetQuizzes.Location = new System.Drawing.Point(490, 67);
            this.btnGetQuizzes.Name = "btnGetQuizzes";
            this.btnGetQuizzes.Size = new System.Drawing.Size(258, 23);
            this.btnGetQuizzes.TabIndex = 3;
            this.btnGetQuizzes.Text = "Load Quizzes from StuQuizzes.txt";
            this.btnGetQuizzes.UseVisualStyleBackColor = true;
            this.btnGetQuizzes.Click += new System.EventHandler(this.btnGetQuizzes_Click);
            // 
            // lstQuizzes
            // 
            this.lstQuizzes.FormattingEnabled = true;
            this.lstQuizzes.ItemHeight = 16;
            this.lstQuizzes.Location = new System.Drawing.Point(381, 154);
            this.lstQuizzes.Name = "lstQuizzes";
            this.lstQuizzes.Size = new System.Drawing.Size(417, 212);
            this.lstQuizzes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quizzes for Selected Student";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(490, 396);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(258, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload Scores to SQL";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // frmStudentGradeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstQuizzes);
            this.Controls.Add(this.btnGetQuizzes);
            this.Controls.Add(this.btnGetStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStudents);
            this.Name = "frmStudentGradeCalculator";
            this.Text = "Student Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetStudents;
        private System.Windows.Forms.Button btnGetQuizzes;
        private System.Windows.Forms.ListBox lstQuizzes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
    }
}

