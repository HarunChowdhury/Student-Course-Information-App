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
    
    class StudentGateWay
    {
        private SqlConnection connection;
        public StudentGateWay()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];

            string connectionString = "";


            if (settings != null)
                connectionString = settings.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }


        public string Save(Student aStudent)
        {
            connection.Open();
            string query =string.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}')", aStudent.RegNo,aStudent.Email,aStudent.Address);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows >= 0)
                return "Insert success";
            return "Something happens wromg";
        }

        public List<Student> GetAllRegNo()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student ");
            SqlCommand command = new SqlCommand(query, connection);

            List<Student> students = new List<Student>();
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.RegNo = aReader[1].ToString();

                   students.Add(aStudent);
                }
            }

            connection.Close();
            return students;
        }
    }
}
