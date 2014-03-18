using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Model
{
    public interface IBookRepository
    {
        void SaveBook(Book book);
        IList<Book> FindAll();
    }
}
