using System.Collections.Generic;
using BSCMS.Model;
using BSCMS.Service.ViewModels;

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
                Price = string.Format("${0:0.00}", book.Price),
                CoverFilePath = "/BookCovers/" + book.FileName
            };
        }

        public static EditBookViewModel ConvertToEditBookViewModel(this Book book)
        {
            return new EditBookViewModel 
            { 
                Title = book.Title,
                Price = string.Format("{0:0.00}", book.Price),
                CoverFilePath = "/BookCovers/" + book.FileName
            };
        }
    }
}
