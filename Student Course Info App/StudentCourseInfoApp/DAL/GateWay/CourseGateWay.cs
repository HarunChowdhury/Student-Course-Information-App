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
    class CourseGateWay
    {
        private SqlConnection connection;
        public CourseGateWay()
        {
           ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];

            string connectionString = "";
         

            if (settings != null)
                connectionString = settings.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

        }

        public string Save(Course aCourse)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Course VALUES('{0}','{1}','{2}')", aCourse.Code,aCourse.Name,aCourse.Credit);                                                           
                SqlCommand command = new SqlCommand(query, connection);

              int affectedRows = command.ExecuteNonQuery();
              connection.Close();
            if (affectedRows >= 0)
                return "Insert success";
            return "Something happens wromg";

        }

        public List<Course> GetAllCourse()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Course ");
            SqlCommand command = new SqlCommand(query, connection);

            List<Course> courses = new List<Course>();
            SqlDataReader aReader = command.ExecuteReader();

             if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.Name = aReader[2].ToString();

                    courses.Add(aCourse);
                }
            }

             connection.Close();
            return courses;


        }
    }
}
