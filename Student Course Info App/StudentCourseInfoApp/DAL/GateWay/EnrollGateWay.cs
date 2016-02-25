using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCourseInfoApp.DAL.DAO;

namespace StudentCourseInfoApp.DAL.GateWay
{
    class EnrollGateWay
    {
        private SqlConnection connection;
        public EnrollGateWay()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];

            string connectionString = "";


            if (settings != null)
                connectionString = settings.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        public string Save(Enroll aEnroll)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Enrollment VALUES('{0}','{1}','{2}')", aEnroll.Name,aEnroll.RegNo,aEnroll.Date);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows >= 0)
                return "Insert success";
            return "Something happens wromg";
        }
    }
}
