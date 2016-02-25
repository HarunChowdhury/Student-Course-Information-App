using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourseInfoApp.DAL.DAO;
using StudentCourseInfoApp.DAL.GateWay;

namespace StudentCourseInfoApp.BLL
{
    class CourseBLL
    {
        private CourseGateWay aCourseGateWay;
        public CourseBLL()
        {
            aCourseGateWay = new CourseGateWay();
        }

      
        public string Save(Course aCourse)
        {
            return aCourseGateWay.Save(aCourse);
        }

        public List<Course> GetAllCourseName()
        {
            List<Course> courses = new List<Course>();
          
            courses= aCourseGateWay.GetAllCourse();
            return courses;
        }
    }
}
