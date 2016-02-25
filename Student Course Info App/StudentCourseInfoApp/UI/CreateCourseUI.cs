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
    public partial class CreateCourseUI : Form
    {
        private CourseBLL aCourseBll;
        private Course aCourse;
        public CreateCourseUI()
        {
            InitializeComponent();
            aCourseBll = new CourseBLL();
        }

        private void saveCourseButton_Click(object sender, EventArgs e)
        {
            Course aCourse = new Course();
            aCourse.Code = courseCodeTextBox.Text;
            aCourse.Name = courseNameTextBox.Text;
            aCourse.Credit = courseCreditTextBox.Text;

            string msg = aCourseBll.Save(aCourse);

            MessageBox.Show(msg);

            

        }
    }
}
