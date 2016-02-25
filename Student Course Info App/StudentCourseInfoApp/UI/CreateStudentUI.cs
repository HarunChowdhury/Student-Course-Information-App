using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentCourseInfoApp.BLL;
using StudentCourseInfoApp.DAL.DAO;

namespace StudentCourseInfoApp.UI
{
    public partial class CreateStudentUI : Form
    {
        private StudentBLL aStudentBll = new StudentBLL();
        public CreateStudentUI()
        {
            InitializeComponent();
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = studentRegNoTextBox.Text;
            aStudent.Email = studentEmailTextBox.Text;
            aStudent.Address = studentAddressTextBox.Text;

            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);


        }
    }
}
