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
    public class BookRepository : IBookRepository
    {
        public void Add(Entities.Models.Book entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"insert into TblBooks(Title, AuthorId, PublicationYear) values (@p1, @p2, @p3)";
            command.Parameters.AddWithValue("@p1", entity.Title);
            command.Parameters.AddWithValue("@p2", entity.AuthorId);
            command.Parameters.AddWithValue("@p3", entity.PublicationYear);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public void Delete(Entities.Models.Book entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"DELETE FROM TblBooks WHERE Id = @BookId";
            command.Parameters.AddWithValue("@bookId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public Entities.Models.Book Get(Expression<Func<Entities.Models.Book, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            Entities.Models.Book book = null;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
               // command.CommandText = "SELECT * FROM TblBooks WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm kitapları almak için varsayılan bir sorgu.
                command.CommandText = "SELECT * FROM TblBooks";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                book = new Entities.Models.Book
                {
                    Id = (int)reader["BookId"],
                    Title = reader["Title"].ToString(),
                    AuthorId = (int)reader["AuthorId"],
                    PublicationYear = (int)reader["PublicationYear"]
                };
            }

            reader.Close();
            connection.Close();

            return book;
        }

      
          
        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
                var connection = new DbConnectionHelper().Connection;
                List<Entities.Models.Book> books = new List<Entities.Models.Book>();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                if (filter != null)
                {
                    // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                    // Örnek: command.CommandText = "SELECT * FROM TblBooks WHERE " + YourCustomFilterLogic(filter);
                }
                else
                {
                    // Tüm kitapları almak için varsayılan bir sorgu.
                    command.CommandText = "SELECT * FROM TblBooks";
                }

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var book = new Entities.Models.Book
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"].ToString(),
                        AuthorId = (int)reader["AuthorId"],
                        PublicationYear = (int)reader["PublicationYear"]
                    };

                    books.Add(book);
                }

                reader.Close();
                connection.Close();

                return books;
            }


            public void Update(Entities.Models.Book entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"UPDATE TblBooks SET Title = @p1, AuthorId = @p2, PublicationYear = @p3 WHERE Id = @BookId";
            command.Parameters.AddWithValue("@p1", entity.Title);
            command.Parameters.AddWithValue("@p2", entity.AuthorId);
            command.Parameters.AddWithValue("@p3", entity.PublicationYear);
            command.Parameters.AddWithValue("@BookId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }
    }
}
