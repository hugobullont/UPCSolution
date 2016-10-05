using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;




namespace DataAccess.StudentRepository
{
    
    public class StudentRepository : IStudentRepository
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UPCDataBase"].ConnectionString;
        public void InsertStudent(Entities.Student student)
        {
            
            
            // define INSERT query with parameters
            //string query = "INSERT INTO Students (Code, Name, Age, GradeAverage) " +
            //               "VALUES (@Code, @Name, @Age, @GradeAverage) ";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Students_InsertStudent", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                
                // define parameters and their values
                cmd.Parameters.Add("@Code", SqlDbType.VarChar, 15).Value = student.Code;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = student.Name;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = student.Age;
                cmd.Parameters.Add("@GradeAverage", SqlDbType.Decimal).Value = student.GradeAverage;
               

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void DeleteStudent(Entities.Student student)
        {
            

            // define INSERT query with parameters
            //string query = "DELETE FROM Students WHERE Students.Id = @id";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Students_DeleteStudent", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // define parameters and their values
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = student.Id;
               
                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void UpdateStudent(Entities.Student student)
        {

            // define INSERT query with parameters
            //string query = "UPDATE Students SET Code = @Code, Name = @Name, Age = @Age, GradeAverage = @GradeAverage WHERE Id = @id";

            // create connection and command
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Students_UpdateStudent", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // define parameters and their values
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = student.Id;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar, 15).Value = student.Code;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = student.Name;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = student.Age;
                cmd.Parameters.Add("@GradeAverage", SqlDbType.Decimal).Value = student.GradeAverage;
               

                // open connection, execute INSERT, close connection
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            
            
         }
    

        public Entities.Student GetStudent(int studentId)
        {
            SqlDataReader reader;
            Entities.Student newStudent = new Entities.Student();

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Students_GetStudent", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // define parameters and their values
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = studentId;
                

                // open connection, execute INSERT, close connection
                cn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    newStudent.Id = Convert.ToInt32(reader["Id"]);
                    newStudent.Code = Convert.ToString(reader["Code"]);
                    newStudent.Name = Convert.ToString(reader["Name"]);
                    newStudent.Age = Convert.ToInt32(reader["Age"]);
                    newStudent.GradeAverage = Convert.ToDecimal(reader["GradeAverage"]);
                }
                reader.Close();
                cn.Close();
            }

            return newStudent;
        }

        public List<Entities.Student> GetAllStudent()
        {
            SqlDataReader reader;
            List<Entities.Student> studentList = new List<Entities.Student>();
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Students_GetListOfStudents", cn))
            {
                
                cmd.CommandType = CommandType.StoredProcedure;
                
                // open connection, execute INSERT, close connection
                cn.Open();
                //cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Entities.Student newStudent = new Entities.Student();
                        newStudent.Id = Convert.ToInt32(reader["Id"]);
                        newStudent.Code = Convert.ToString(reader["Code"]);
                        newStudent.Name = Convert.ToString(reader["Name"]);
                        newStudent.Age = Convert.ToInt32(reader["Age"]);
                        newStudent.GradeAverage = Convert.ToDecimal(reader["GradeAverage"]);
                        studentList.Add(newStudent);
                    }
                }
                reader.Close();
                cn.Close();
            }

            return studentList;
        }
    }
}
