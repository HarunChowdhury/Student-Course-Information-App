namespace StudentCourseInfoApp.UI
{
    partial class EnrollMentUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.enrollButton = new System.Windows.Forms.Button();
            this.stdRegNoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(171, 191);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(152, 43);
            this.enrollButton.TabIndex = 8;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // stdRegNoComboBox
            // 
            this.stdRegNoComboBox.FormattingEnabled = true;
            this.stdRegNoComboBox.Location = new System.Drawing.Point(154, 72);
            this.stdRegNoComboBox.Name = "stdRegNoComboBox";
            this.stdRegNoComboBox.Size = new System.Drawing.Size(258, 21);
            this.stdRegNoComboBox.TabIndex = 11;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student Reg No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course Name";
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(154, 25);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(258, 21);
            this.courseComboBox.TabIndex = 14;
        
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(154, 122);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // EnrollMentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 296);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stdRegNoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enrollButton);
            this.Name = "EnrollMentUI";
            this.Text = "EnrollMentUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.ComboBox stdRegNoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}