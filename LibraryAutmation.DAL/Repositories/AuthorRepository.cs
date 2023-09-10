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
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Entities.Models.Author entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"insert into TblAuthors(FirstName, LastName, BirthDate) values (@p1, @p2, @p3)";
            command.Parameters.AddWithValue("@p1", entity.FirstName);
            command.Parameters.AddWithValue("@p2", entity.LastName);
            command.Parameters.AddWithValue("@p3", entity.BirthDate);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public void Delete(Entities.Models.Author entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"DELETE FROM TblAuthors WHERE Id = @authorId";
            command.Parameters.AddWithValue("@authorId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public Entities.Models.Author Get(Expression<Func<Entities.Models.Author, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            Entities.Models.Author author = null;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                // Örnek: command.CommandText = "SELECT * FROM TblAuthors WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm yazarları almak için varsayılan bir sorgu.
                command.CommandText = "SELECT  * FROM TblAuthors";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                author = new Entities.Models.Author
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    BirthDate = (DateTime)reader["BirthDate"]
                };
            }

            reader.Close();
            connection.Close();

            return author;
        }

        public List<Entities.Models.Author> GetAl1(Expression<Func<Entities.Models.Author, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Models.Author> GetAll(Expression<Func<Entities.Models.Author, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            List<Entities.Models.Author> authors = new List<Entities.Models.Author>();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                // Örnek: command.CommandText = "SELECT * FROM TblAuthors WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm yazarları almak için varsayılan bir sorgu.
                command.CommandText = "SELECT * FROM TblAuthors";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var author = new Entities.Models.Author
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    BirthDate = (DateTime)reader["BirthDate"]
                };

                authors.Add(author);
            }

            reader.Close();
            connection.Close();

            return authors;
        }

        public void Update(Entities.Models.Author entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"UPDATE TblAuthors SET FirstName = @p1, LastName = @p2, BirthDate = @p3 WHERE Id = @authorId";
            command.Parameters.AddWithValue("@p1", entity.FirstName);
            command.Parameters.AddWithValue("@p2", entity.LastName);
            command.Parameters.AddWithValue("@p3", entity.BirthDate);
            command.Parameters.AddWithValue("@authorId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }
    }
}