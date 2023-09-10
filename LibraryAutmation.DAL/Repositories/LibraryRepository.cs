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
    public class LibraryRepository : ILibraryRepository
    {
        public void Add(Entities.Models.Library entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"INSERT INTO TblLibraries(Name, Location, ContactEmail, FoundingYear, PhoneNumber, Website) 
                            VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            command.Parameters.AddWithValue("@p1", entity.LibraryName);
            command.Parameters.AddWithValue("@p2", entity.Location);
            command.Parameters.AddWithValue("@p3", entity.ContactEmail);
            command.Parameters.AddWithValue("@p4", entity.FoundingYear);
            command.Parameters.AddWithValue("@p5", entity.PhoneNumber);
            command.Parameters.AddWithValue("@p6", entity.Website);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }


        public void Delete(Entities.Models.Library entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"DELETE FROM TblLibraries WHERE Id = @LibraryId";
            command.Parameters.AddWithValue("@LibraryId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public Entities.Models.Library Get(Expression<Func<Entities.Models.Library, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            Entities.Models.Library library = null;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                // Örnek: command.CommandText = "SELECT * FROM TblLibraries WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm kütüphaneleri almak için varsayılan bir sorgu.
                command.CommandText = "SELECT * FROM TblLibraries";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                library = new Entities.Models.Library
                {
                    Id = (int)reader["Id"],
                    LibraryName = reader["LibraryName"].ToString(),
                    Location = reader["Location"].ToString(),
                    ContactEmail = reader["ContactEmail"].ToString(),
                    FoundingYear = (int)reader["FoundingYear"],
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    Website = reader["Website"].ToString(),

                };
            }

            reader.Close();
            connection.Close();

            return library;
        }

        
        public List<Library> GetAll(Expression<Func<Library, bool>> filter = null)
        {
                var connection = new DbConnectionHelper().Connection;
                List<Entities.Models.Library> libraries = new List<Entities.Models.Library>();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                if (filter != null)
                {
                    // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                    // Örnek: command.CommandText = "SELECT * FROM TblLibraries WHERE " + YourCustomFilterLogic(filter);
                }
                else
                {
                    // Tüm kütüphaneleri almak için varsayılan bir sorgu.
                    command.CommandText = "SELECT * FROM TblLibraries";
                }

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var library = new Entities.Models.Library
                    {
                        Id = (int)reader["Id"],
                        LibraryName = reader["Name"].ToString(),
                        Location = reader["Location"].ToString(),
                        ContactEmail = reader["ContactEmail"].ToString(),
                        FoundingYear = (int)reader["FoundingYear"],
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Website = reader["Website"].ToString()
                    };

                    libraries.Add(library);
                }

                reader.Close();
                connection.Close();

                return libraries;
            }


            public void Update(Entities.Models.Library entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"UPDATE TblLibraries SET Name = @p1, Location = @p2, ContactEmail = @p3, FoundingYear = @p4, PhoneNumber = @p5, Website = @p6 WHERE Id = @LibraryId";
            command.Parameters.AddWithValue("@p1", entity.LibraryName);
            command.Parameters.AddWithValue("@p2", entity.Location);
            command.Parameters.AddWithValue("@p3", entity.ContactEmail);
            command.Parameters.AddWithValue("@p4", entity.FoundingYear);
            command.Parameters.AddWithValue("@p5", entity.PhoneNumber);
            command.Parameters.AddWithValue("@p6", entity.Website);
            command.Parameters.AddWithValue("@LibraryId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }
    }
}