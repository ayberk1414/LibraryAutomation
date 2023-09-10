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
    public class PersonelRepository : IPersonelRepository
    {
        public void Add(Entities.Models.Personel entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"INSERT INTO TblPersonel(FirstName, LastName, BirtDate, Gender, Password, LibraryId) 
                            VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            command.Parameters.AddWithValue("@p1", entity.FirstName);
            command.Parameters.AddWithValue("@p2", entity.LastName);
            command.Parameters.AddWithValue("@p3", entity.BirtDate);
            command.Parameters.AddWithValue("@p4", entity.Gender);
            command.Parameters.AddWithValue("@p5", entity.Password);
            command.Parameters.AddWithValue("@p6", entity.LibrayId);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public void Delete(Entities.Models.Personel entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"DELETE FROM TblPersonel WHERE Id = @PersonelId";
            command.Parameters.AddWithValue("PpersonelId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

        public Entities.Models.Personel Get(Expression<Func<Entities.Models.Personel, bool>> filter = null)
        {
            var connection = new DbConnectionHelper().Connection;
            Entities.Models.Personel personel = null;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            if (filter != null)
            {
                // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                // Örnek: command.CommandText = "SELECT * FROM TblPersonel WHERE " + YourCustomFilterLogic(filter);
            }
            else
            {
                // Tüm personelleri almak için varsayılan bir sorgu.
                command.CommandText = "SELECT * FROM TblPersonel";
            }

            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                personel = new Entities.Models.Personel
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = (string)reader["LastName"],
                    BirtDate = (DateTime)reader["BirtDate"],
                    Gender = (string)reader["Gender"],
                    Password = reader["Password"].ToString(),
                    LibrayId = (int)reader["LibraryId"]

                };
            }

            reader.Close();
            connection.Close();

            return personel;
        }

       
        public List<Personel> GetAll(Expression<Func<Personel, bool>> filter = null)
        {
                var connection = new DbConnectionHelper().Connection;
                List<Entities.Models.Personel> personeller = new List<Entities.Models.Personel>();

                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                if (filter != null)
                {
                    // Özelleştirilmiş filtreleme sorgusu burada uygulanabilir.
                    // Örnek: command.CommandText = "SELECT * FROM TblPersonel WHERE " + YourCustomFilterLogic(filter);
                }
                else
                {
                    // Tüm personelleri almak için varsayılan bir sorgu.
                    command.CommandText = "SELECT * FROM TblPersonel";
                }

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var personel = new Entities.Models.Personel
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirtDate = (DateTime)reader["BirtDate"],
                        Gender = reader["Gender"].ToString(),
                        Password = reader["Password"].ToString(),
                        LibrayId = (int)reader["LibraryId"]
                    };

                    personeller.Add(personel);
                }

                reader.Close();
                connection.Close();

                return personeller;
            }

            public void Update(Entities.Models.Personel entity)
        {
            var connection = new DbConnectionHelper().Connection;

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = @"UPDATE TblPersonel 
                            SET FirstName = @p1, LastName = @p2, BirtDate = @p3, Gender = @p4, Password = @p5, LibraryId = @p6
                            WHERE Id = @personelId";
            command.Parameters.AddWithValue("@p1", entity.FirstName);
            command.Parameters.AddWithValue("@p2", entity.LastName);
            command.Parameters.AddWithValue("@p3", entity.BirtDate);
            command.Parameters.AddWithValue("@p4", entity.Gender);
            command.Parameters.AddWithValue("@p5", entity.Password);
            command.Parameters.AddWithValue("@p6", entity.LibrayId);
            command.Parameters.AddWithValue("@personelId", entity.Id);

            connection.Open();
            var returnValue = command.ExecuteNonQuery();
            int rv = Convert.ToInt32(returnValue);
            command.Parameters.Clear();
            connection.Close();
        }

    }
}
