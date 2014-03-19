using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class EditBookPresenter
    {
        private IEditBookView _editBookView;
        private BookService _bookService;

        public EditBookPresenter(IEditBookView editBookView, BookService bookService)
        {
            _editBookView = editBookView;
            _bookService = bookService;
        }

        public void Display()
        {
            EditBookDisplayRequest editBookDisplayRequest = new EditBookDisplayRequest();
            editBookDisplayRequest.BookId = _editBookView.Id;

            EditBookDisplayResponse editBookDisplayResponse = _bookService.GetBookForEdit(editBookDisplayRequest);

            _editBookView.Display(editBookDisplayResponse.Book);
        }
    }
}
