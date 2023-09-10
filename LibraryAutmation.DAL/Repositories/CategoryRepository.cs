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
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Entities.Models.Category entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"INSERT INTO TblCategories(CategoryName, Description) VALUES (@p1, @p2)";
            command.Parameters.AddWithValue("@p1", entity.CategoryName);
            command.Parameters.AddWithValue("@p2", entity.Description);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public void Delete(Entities.Models.Category entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"DELETE FROM TblCategories WHERE Id = @CategoryId";
            command.Parameters.AddWithValue("@CategoryId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public Entities.Models.Category Get(Expression<Func<Entities.Models.Category, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            Entities.Models.Category category = null;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                // Örnek: command.CommandText = "SELECT * FROM TblCategories WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm kategorileri almak için varsayılan bir sorgu.
                command.CommandText = "SELECT * FROM TblCategories";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                category = new Entities.Models.Category
                {
                    Id = (int)reader["Id"],
                    CategoryName = reader["CategoryName"].ToString(),
                    Description = reader["Description"].ToString()
                };
            }

            reader.Close();
            connection.Close();

            return category;
        }

        
        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            List<Entities.Models.Category> categories = new List<Entities.Models.Category>();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                // Örnek: command.CommandText = "SELECT * FROM TblCategories WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm kategorileri almak için varsayılan bir sorgu.
                command.CommandText = "SELECT * FROM TblCategories";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var category = new Entities.Models.Category
                {
                    Id = (int)reader["Id"],
                    CategoryName = reader["CategoryName = reader[\"Name\"].ToString(),\r\n"].ToString(),
                    Description = reader["Description"].ToString()
                };

                categories.Add(category);
            }

            reader.Close();
            connection.Close();

            return categories;
        }

        public void Update(Entities.Models.Category entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"UPDATE TblCategories SET Name = @p1, Description = @p2 WHERE Id = @CategoryId";
            command.Parameters.AddWithValue("@p1", entity.CategoryName);
            command.Parameters.AddWithValue("@p2", entity.Description);
            command.Parameters.AddWithValue("@CategoryId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }
    }
}