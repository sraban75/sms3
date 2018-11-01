using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using SMS.Models;

namespace SMS.DAL
{
    public class StudentRepository
    {
        static string conString = @"Server=BITMTRAINER-301\SQLEXPRESS; Database=EmployeeDb_52_13; Integrated Security=true";
        SqlConnection con = new SqlConnection(conString);
        public bool Save(Student student)
        {
            string query = @"INSERT INTO Students (Name,CityId) VALUES ('" + student.Name + "'," + student.CityId + ")";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int rowCount = command.ExecuteNonQuery();
            con.Close();
            if (rowCount > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetAll()
        {
            string query = @"SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);

            List<Student> students= new List<Student>();

            //foreach (var VARIABLE in dt)
            //{
            //    Student student = new Student();
            //    student.Name = urColumnName["Name"].ToString();

            //    students.Add(student);
            //}

            return dt;
        }
    }
}