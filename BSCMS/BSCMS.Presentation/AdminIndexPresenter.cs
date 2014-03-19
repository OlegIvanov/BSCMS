using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class AdminIndexPresenter
    {
        private IAdminIndexView _adminIndexView;
        private BookService _bookService;

        public AdminIndexPresenter(IAdminIndexView adminIndexView, BookService bookService)
        {
            _adminIndexView = adminIndexView;
            _bookService = bookService;
        }

        public void Display()
        {
            BookListResponse bookListResponse = _bookService.GetBookList();

            _adminIndexView.Display(bookListResponse.Books);
        }

        public void DeleteBook()
        {
            DeleteBookRequest deleteBookRequest = new DeleteBookRequest();
            deleteBookRequest.BookId = _adminIndexView.BookId;

            _bookService.DeleteBook(deleteBookRequest);
        }
    }
}
