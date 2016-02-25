namespace StudentCourseInfoApp
{
    partial class MainUI
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
            this.courseButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.enrollMentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(166, 36);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(119, 41);
            this.courseButton.TabIndex = 0;
            this.courseButton.Text = "Create Course";
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(166, 97);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(119, 49);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Create Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // enrollMentButton
            // 
            this.enrollMentButton.Location = new System.Drawing.Point(166, 164);
            this.enrollMentButton.Name = "enrollMentButton";
            this.enrollMentButton.Size = new System.Drawing.Size(119, 55);
            this.enrollMentButton.TabIndex = 2;
            this.enrollMentButton.Text = "EnrollMent";
            this.enrollMentButton.UseVisualStyleBackColor = true;
            this.enrollMentButton.Click += new System.EventHandler(this.enrollMentButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 320);
            this.Controls.Add(this.enrollMentButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.courseButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button enrollMentButton;
    }
}

