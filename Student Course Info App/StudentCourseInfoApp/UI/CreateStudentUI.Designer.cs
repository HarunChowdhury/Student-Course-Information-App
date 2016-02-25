namespace StudentCourseInfoApp.UI
{
    partial class CreateStudentUI
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
            this.studentAddressTextBox = new System.Windows.Forms.TextBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentAddressTextBox
            // 
            this.studentAddressTextBox.Location = new System.Drawing.Point(179, 107);
            this.studentAddressTextBox.Multiline = true;
            this.studentAddressTextBox.Name = "studentAddressTextBox";
            this.studentAddressTextBox.Size = new System.Drawing.Size(320, 49);
            this.studentAddressTextBox.TabIndex = 7;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(179, 69);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(320, 20);
            this.studentEmailTextBox.TabIndex = 8;
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(179, 30);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(320, 20);
            this.studentRegNoTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Reg No";
            // 
            // studentSaveButton
            // 
            this.studentSaveButton.Location = new System.Drawing.Point(248, 210);
            this.studentSaveButton.Name = "studentSaveButton";
            this.studentSaveButton.Size = new System.Drawing.Size(152, 43);
            this.studentSaveButton.TabIndex = 3;
            this.studentSaveButton.Text = "Save";
            this.studentSaveButton.UseVisualStyleBackColor = true;
            this.studentSaveButton.Click += new System.EventHandler(this.studentSaveButton_Click);
            // 
            // CreateStudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 370);
            this.Controls.Add(this.studentAddressTextBox);
            this.Controls.Add(this.studentEmailTextBox);
            this.Controls.Add(this.studentRegNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentSaveButton);
            this.Name = "CreateStudentUI";
            this.Text = "CreateStudentUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentAddressTextBox;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.TextBox studentRegNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentSaveButton;
    }
}