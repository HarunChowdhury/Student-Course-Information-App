using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseInfoApp.DAL.DAO
{
    class Course
    {
        public int CourseId{ get; set; }
        public string  Code { get; set; }
        public string  Name { get; set; }
        public string  Credit { get; set; }

        public Course(string code,string name,string credit):this()
        {
            Code = code;
            Name = name;
            Credit = credit;
        }

        public Course()
        {

        }
    }
}
