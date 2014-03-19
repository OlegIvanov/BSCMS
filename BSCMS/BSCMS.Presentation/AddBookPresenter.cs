using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.Messages;
using BSCMS.Service;
using BSCMS.Presentation.Navigation;

namespace BSCMS.Presentation
{
    public class AddBookPresenter
    {
        private IAddBookView _addBookView;
        private BookService _bookService;
        private IPageNavigator _pageNavigator;

        public AddBookPresenter(IAddBookView addBookView, BookService bookService, IPageNavigator pageNavigator)
        {
            _addBookView = addBookView;
            _bookService = bookService;
            _pageNavigator = pageNavigator;
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

            _pageNavigator.NavigateTo(PageDirectory.AdminHome);
        }
    }
}
