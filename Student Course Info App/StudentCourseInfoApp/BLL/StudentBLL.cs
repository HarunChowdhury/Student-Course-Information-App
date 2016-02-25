using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourseInfoApp.DAL.DAO;
using StudentCourseInfoApp.DAL.GateWay;

namespace StudentCourseInfoApp.BLL
{
    class StudentBLL
    {
        private StudentGateWay aStudentGateWay;
        public StudentBLL()
        {
            aStudentGateWay = new StudentGateWay();
        }

       
        public string Save(Student aStudent)
        {
            return aStudentGateWay.Save(aStudent);
        }

        public List<Student> GetAllRegNo()
        {
            List<Student> students = new List<Student>();

            students=aStudentGateWay.GetAllRegNo();
            return students;
        }
    }
}
