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

        public void SaveBook(Book book)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SaveBook", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Title", SqlDbType.NVarChar, 200).Value = book.Title;
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = book.Price;
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
