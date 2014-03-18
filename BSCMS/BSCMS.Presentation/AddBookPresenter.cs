using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.Messages;
using BSCMS.Service;

namespace BSCMS.Presentation
{
    public class AddBookPresenter
    {
        private IAddBookView _addBookView;
        private BookService _bookService;

        public AddBookPresenter(IAddBookView addBookView, BookService bookService)
        {
            _addBookView = addBookView;
            _bookService = bookService;
        }

        public void SaveBook()
        {
            AddBookRequest addBookRequest = new AddBookRequest 
            { 
                Title = _addBookView.Title_,
                Price = _addBookView.Price,
                Cover = _addBookView.Cover
            };

            _bookService.AddBook(addBookRequest);
        }
    }
}
