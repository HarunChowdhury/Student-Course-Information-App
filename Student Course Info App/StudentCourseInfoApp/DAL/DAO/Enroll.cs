using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseInfoApp.DAL.DAO
{
    class Enroll
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string RegNo { get; set; }
        public string Date { get; set; }


        public Enroll(string name,string regNo,string date):this()
        {
            Name = name;
            RegNo = regNo;
            Date = date;
        }

        public Enroll()
        {

        }
    }
}
