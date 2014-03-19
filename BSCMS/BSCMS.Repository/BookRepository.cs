using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Model;
using System.Data.SqlClient;
using System.Data;

namespace BSCMS.Repository
{
    public class BookRepository : IBookRepository
    {
        private string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Save(Book book)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SaveBook", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = book.Title;
                command.Parameters.Add("@Price", SqlDbType.Money).Value = book.Price;
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 100).Value = book.FileName;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public IList<Book> FindAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllBooks", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    return GetBookCollectionFromReader(reader);
                }
            }
        }

        public void Delete(int bookId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("DeleteBook", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@BookId", SqlDbType.Int).Value = bookId;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("UpdateBook", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@BookId", SqlDbType.Int).Value = book.Id;
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = book.Title;
                command.Parameters.Add("@Price", SqlDbType.Money).Value = book.Price;
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 100).Value = book.FileName;

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public Book FindBy(int bookId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetBookById", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@BookId", SqlDbType.Int).Value = bookId;

                connection.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    return GetBookCollectionFromReader(reader).FirstOrDefault();
                }
            }
        }

        private IList<Book> GetBookCollectionFromReader(IDataReader dataReader)
        {
            IList<Book> books = new List<Book>();

            while (dataReader.Read())
            {
                books.Add(new Book 
                { 
                    Id = (int)dataReader["Id"],
                    Title = (string)dataReader["Title"],
                    Price = (decimal)dataReader["Price"],
                    FileName = (string)dataReader["FileName"]
                });
            }

            return books;
        }
    }
}
