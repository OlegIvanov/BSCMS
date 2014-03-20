using BSCMS.Presentation.Navigation;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class EditBookPresenter
    {
        private IEditBookView _editBookView;
        private BookService _bookService;
        private IPageNavigator _pageNavigator;

        public EditBookPresenter(IEditBookView editBookView, BookService bookService, IPageNavigator pageNavigator)
        {
            _editBookView = editBookView;
            _bookService = bookService;
            _pageNavigator = pageNavigator;
        }

        public void Display()
        {
            EditBookDisplayRequest editBookDisplayRequest = new EditBookDisplayRequest();
            editBookDisplayRequest.BookId = _editBookView.Id;

            EditBookDisplayResponse editBookDisplayResponse = _bookService.GetBookForEdit(editBookDisplayRequest);

            _editBookView.Display(editBookDisplayResponse.Book);
        }

        public void EditBook()
        {
            EditBookRequest editBookRequest = new EditBookRequest 
            { 
                Id = _editBookView.Id,
                Title = _editBookView.Title_,
                Price = _editBookView.Price,
                Cover = _editBookView.Cover
            };

            _bookService.EditBook(editBookRequest);

            _pageNavigator.NavigateTo(PageDirectory.AdminHome);
        }
    }
}
