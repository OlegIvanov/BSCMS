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
    }
}
