using DataGridView.DAL.Helpers;
using LibraryAutmation.DAL.Interface;
using LibraryAutmation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DAL.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Entities.Models.Student entity)
        {
            var connection = new DbConnectionHelper().Connection;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = @"INSERT INTO TblStudent(StudentName, StudentSurname, Password, TCKN) 
                            VALUES (@p1, @p2, @p3, @p4)";
                command.Parameters.AddWithValue("@p1", entity.StudentName);
                command.Parameters.AddWithValue("@p2", entity.StudentSurname);
                command.Parameters.AddWithValue("@p3", entity.Password);
                command.Parameters.AddWithValue("@p4", entity.TCKN);

                connection.Open();
                var returnValue = command.ExecuteNonQuery();
                int rv = Convert.ToInt32(returnValue);
                connection.Close();
            }
        }

        public void Delete(Entities.Models.Student entity)
        {
            var connection = new DbConnectionHelper().Connection;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = @"DELETE FROM TblStudent WHERE StudentId = @StudentId";
                command.Parameters.AddWithValue("@StudentId", entity.StudentId);

                connection.Open();
                var returnValue = command.ExecuteNonQuery();
                int rv = Convert.ToInt32(returnValue);
                connection.Close();
            }
        }

        public Entities.Models.Student Get(Expression<Func<Entities.Models.Student, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            Entities.Models.Student student = null;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                if (filter != null)
                {
                    // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                    // Örnek: command.CommandText = "SELECT * FROM TblStudent WHERE " + YourCustomFilterLogic(filter);
                }
                else
                {
                    // Tüm öğrencileri almak için varsayılan bir sorgu.
                    command.CommandText = "SELECT * FROM TblStudent";
                }

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student = new Entities.Models.Student
                        {
                            StudentId = (int)reader["StudentId"],
                            StudentName = reader["StudentName"].ToString(),
                            StudentSurname = reader["StudentSurname"].ToString(),
                            Password = reader["Password"].ToString(),
                            TCKN = reader["TCKN"].ToString()
                        };
                    }
                }
                connection.Close();
            }

            return student;
        }

       

        public List<Student> GetAll(Expression<Func<Student, bool>> filter = null)
        {

                var connection = new DbConnectionHelper().Connection;
                List<Entities.Models.Student> students = new List<Entities.Models.Student>();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;

                    if (filter != null)
                    {
                        // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                        // Örnek: command.CommandText = "SELECT * FROM TblStudent WHERE " + YourCustomFilterLogic(filter);
                    }
                    else
                    {
                        // Tüm öğrencileri almak için varsayılan bir sorgu.
                        command.CommandText = "SELECT * FROM TblStudent";
                    }

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Entities.Models.Student
                            {
                                StudentId = (int)reader["StudentId"],
                                StudentName = reader["StudentName"].ToString(),
                                StudentSurname = reader["StudentSurname"].ToString(),
                                Password = reader["Password"].ToString(),
                                TCKN = reader["TCKN"].ToString()
                            };

                            students.Add(student);
                        }
                    }
                    connection.Close();
                }

                return students;
            }


            public void Update(Entities.Models.Student entity)
        {
            var connection = new DbConnectionHelper().Connection;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = @"UPDATE TblStudent 
                            SET StudentName = @p1, StudentSurname = @p2, Password = @p3, TCKN = @p4
                            WHERE StudentId = @StudentId";
                command.Parameters.AddWithValue("@p1", entity.StudentName);
                command.Parameters.AddWithValue("@p2", entity.StudentSurname);
                command.Parameters.AddWithValue("@p3", entity.Password);
                command.Parameters.AddWithValue("@p4", entity.TCKN);
                command.Parameters.AddWithValue("@StudentId", entity.StudentId);

                connection.Open();
                var returnValue = command.ExecuteNonQuery();
                int rv = Convert.ToInt32(returnValue);
                connection.Close();
            }
        }

    }

}
    

    

        
