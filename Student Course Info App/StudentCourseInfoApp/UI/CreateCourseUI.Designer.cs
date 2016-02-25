namespace StudentCourseInfoApp.UI
{
    partial class CreateCourseUI
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
            this.saveCourseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseCreditTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveCourseButton
            // 
            this.saveCourseButton.Location = new System.Drawing.Point(265, 161);
            this.saveCourseButton.Name = "saveCourseButton";
            this.saveCourseButton.Size = new System.Drawing.Size(152, 43);
            this.saveCourseButton.TabIndex = 0;
            this.saveCourseButton.Text = "Save";
            this.saveCourseButton.UseVisualStyleBackColor = true;
            this.saveCourseButton.Click += new System.EventHandler(this.saveCourseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // courseCodeTextBox
            // 
            this.courseCodeTextBox.Location = new System.Drawing.Point(169, 33);
            this.courseCodeTextBox.Name = "courseCodeTextBox";
            this.courseCodeTextBox.Size = new System.Drawing.Size(320, 20);
            this.courseCodeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(169, 72);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(320, 20);
            this.courseNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Credit";
            // 
            // courseCreditTextBox
            // 
            this.courseCreditTextBox.Location = new System.Drawing.Point(169, 110);
            this.courseCreditTextBox.Name = "courseCreditTextBox";
            this.courseCreditTextBox.Size = new System.Drawing.Size(320, 20);
            this.courseCreditTextBox.TabIndex = 2;
            // 
            // CreateCourseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 264);
            this.Controls.Add(this.courseCreditTextBox);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveCourseButton);
            this.Name = "CreateCourseUI";
            this.Text = "CreateCourseUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveCourseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courseCreditTextBox;
    }
}