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
    public partial class EnrollMentUI : Form
    {
        private CourseBLL aCourseBll;
        private StudentBLL aStudentBll;
        private EnrollBLL aEnrollBll;
        public EnrollMentUI()
        {
          
            InitializeComponent();
            aEnrollBll = new EnrollBLL();
            
            aCourseBll = new CourseBLL();
            aStudentBll = new StudentBLL();
            courseComboBox.DisplayMember = "Name";
            List<Course> courses = new List<Course>();

            courses = aCourseBll.GetAllCourseName();
            foreach (Course aCourse in courses)
            {

                courseComboBox.Items.Add(aCourse);
            }

            stdRegNoComboBox.DisplayMember = "RegNo";
            List<Student> students;
            students = aStudentBll.GetAllRegNo();
            foreach (Student aStudent in students)
            {

                stdRegNoComboBox.Items.Add(aStudent);
            }
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            Enroll aEnroll = new Enroll();
            aEnroll.Name = courseComboBox.Text;
            aEnroll.RegNo = stdRegNoComboBox.Text;
            aEnroll.Date = dateTimePicker.Text;

            string msg= aEnrollBll.Save(aEnroll);

            MessageBox.Show(msg);


        }
    }
}
