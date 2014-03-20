using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class HomeIndexPresenter
    {
        private IHomeIndexView _homeIndexView;
        private BookService _bookService;

        public HomeIndexPresenter(IHomeIndexView homeIndexView, BookService bookService)
        {
            _homeIndexView = homeIndexView;
            _bookService = bookService;
        }

        public void Display()
        {
            BookListResponse bookListResponse = _bookService.GetBookList();

            _homeIndexView.Display(bookListResponse.Books);
        }
    }
}
