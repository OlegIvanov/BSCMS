﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Model
{
    public interface IBookRepository
    {
        void Save(Book book);
        IList<Book> FindAll();
        void Delete(int bookId);
        Book FindBy(int bookId);
        void Update(Book book);
    }
}
