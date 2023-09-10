using DataGridView.DAL.Helpers;
using LibraryAutmation.DAL.Interface;
using LibraryAutmation.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutmation.DAL.Repositories
{


    public class ToLendRepository:IToLendRepository
    {
        public void Add(ToLend entity)
        {
            var connection = new DbConnectionHelper().Connection;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = @"INSERT INTO TblToLend(PersonelId, BookId, LendDate, ReturnDate, TargetDate) 
                                VALUES (@p1, @p2, @p3, @p4, @p5)";
                command.Parameters.AddWithValue("@p1", entity.PersonelId);
                command.Parameters.AddWithValue("@p2", entity.BookId);
                command.Parameters.AddWithValue("@p3", entity.LendDate);
                command.Parameters.AddWithValue("@p4", entity.ReturnDate);
                command.Parameters.AddWithValue("@p5", entity.TargetDate);

                connection.Open();
                var returnValue = command.ExecuteNonQuery();
                int rv = Convert.ToInt32(returnValue);
                connection.Close();
            }
        }

        public void Delete(ToLend entity)
        {
            var connection = new DbConnectionHelper().Connection;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = @"DELETE FROM TblToLend WHERE Id = @id";
                command.Parameters.AddWithValue("@id", entity.Id);

                connection.Open();
                var returnValue = command.ExecuteNonQuery();
                int rv = Convert.ToInt32(returnValue);
                connection.Close();
            }
        }

        public ToLend Get(Expression<Func<ToLend, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            ToLend toLend = null;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                if (filter != null)
                {
                    // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                    // Örnek: command.CommandText = "SELECT * FROM TblToLend WHERE " + YourCustomFilterLogic(filter);
                }
                else
                {
                    // Tüm ödünçleri almak için varsayılan bir sorgu.
                    command.CommandText = "SELECT * FROM TblToLend";
                }

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        toLend = new ToLend
                        {
                            Id = (int)reader["Id"],
                            PersonelId = (int)reader["PersonelId"],
                            BookId = (int)reader["BookId"],
                            LendDate = (DateTime)reader["LendDate"],
                            ReturnDate = (DateTime)reader["ReturnDate"],
                            TargetDate = (DateTime)reader["TargetDate"]
                        };
                    }
                }
                connection.Close();
            }

            return toLend;
        }

      
            

        public List<ToLend> GetAll(Expression<Func<ToLend, bool>> filter = null)
        {
                var connection = new DbConnectionHelper().Connection;
                List<ToLend> toLendList = new List<ToLend>();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;

                    if (filter != null)
                    {
                        // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                        // Örnek: command.CommandText = "SELECT * FROM TblToLend WHERE " + YourCustomFilterLogic(filter);
                    }
                    else
                    {
                        // Tüm ödünçleri almak için varsayılan bir sorgu.
                        command.CommandText = "SELECT * FROM TblToLend";
                    }

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var toLend = new ToLend
                            {
                                Id = (int)reader["Id"],
                                PersonelId = (int)reader["PersonelId"],
                                BookId = (int)reader["BookId"],
                                LendDate = (DateTime)reader["LendDate"],
                                ReturnDate = (DateTime)reader["ReturnDate"],
                                TargetDate = (DateTime)reader["TargetDate"]
                            };

                            toLendList.Add(toLend);
                        }
                    }
                    connection.Close();
                }

                return toLendList;
            }

            public void Update(ToLend entity)
        {
            var connection = new DbConnectionHelper().Connection;

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = @"UPDATE TblToLend 
                                SET PersonelId = @p1, BookId = @p2, LendDate = @p3, ReturnDate = @p4, TargetDate = @p5
                                WHERE Id = @id";
                command.Parameters.AddWithValue("@p1", entity.PersonelId);
                command.Parameters.AddWithValue("@p2", entity.BookId);
                command.Parameters.AddWithValue("@p3", entity.LendDate);
                command.Parameters.AddWithValue("@p4", entity.ReturnDate);
                command.Parameters.AddWithValue("@p5", entity.TargetDate);
                command.Parameters.AddWithValue("@id", entity.Id);

                connection.Open();
                var returnValue = command.ExecuteNonQuery();
                int rv = Convert.ToInt32(returnValue);
                connection.Close();
            }
        }
    }
}