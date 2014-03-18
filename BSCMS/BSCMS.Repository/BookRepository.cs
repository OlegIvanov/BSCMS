using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Model;

namespace BSCMS.Repository
{
    public class BookRepository : IBookRepository
    {
        private string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
