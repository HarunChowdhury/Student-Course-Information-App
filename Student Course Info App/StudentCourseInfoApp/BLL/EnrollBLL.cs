using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourseInfoApp.DAL.DAO;
using StudentCourseInfoApp.DAL.GateWay;

namespace StudentCourseInfoApp.BLL
{
    class EnrollBLL
    {
        private EnrollGateWay aEnrollGateWay;
        public EnrollBLL()
        {
            aEnrollGateWay = new EnrollGateWay();
        }


        public string Save(Enroll aEnroll)
        {
            return aEnrollGateWay.Save(aEnroll);
        }
    }
}
