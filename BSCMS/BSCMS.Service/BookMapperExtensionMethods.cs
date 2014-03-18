using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.ViewModels;
using BSCMS.Model;
using BSCMS.Infrastructure;
using System.IO;

namespace BSCMS.Service
{
    public static class BookMapperExtensionMethods
    {
        public static IList<BookViewModel> ConvertToBookListViewModel(this IList<Book> books)
        {
            IList<BookViewModel> bookViewModels = new List<BookViewModel>();

            foreach (Book book in books) 
            {
                bookViewModels.Add(book.ConvertToBookViewModel());
            }

            return bookViewModels;
        }

        public static BookViewModel ConvertToBookViewModel(this Book book)
        {
            return new BookViewModel 
            { 
                Id = book.Id,
                Title = book.Title,
                Price = book.Price.ToString(),
                FileName = book.FileName
            };
        }
    }
}
