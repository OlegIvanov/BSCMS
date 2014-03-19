using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Model;
using BSCMS.Service.Messages;
using System.IO;
using BSCMS.Infrastructure;

namespace BSCMS.Service
{
    public class BookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(AddBookRequest addBookRequest)
        {
            string coverFileName = BookCoverFileUtility.SaveCover(addBookRequest.Cover);

            Book book = new Book
            {
                Title = addBookRequest.Title,
                Price = addBookRequest.Price,
                FileName = coverFileName
            };

            _bookRepository.Save(book);
        }

        public BookListResponse GetBookList()
        {
            IList<Book> books = _bookRepository.FindAll();

            BookListResponse bookListResponse = new BookListResponse();
            bookListResponse.Books = books.ConvertToBookListViewModel();

            return bookListResponse;
        }

        public void DeleteBook(DeleteBookRequest deleteBookRequest)
        {
            Book book = _bookRepository.FindBy(deleteBookRequest.BookId);

            BookCoverFileUtility.DeleteCover(book.FileName);

            _bookRepository.Delete(deleteBookRequest.BookId);
        }

        public EditBookDisplayResponse GetBookForEdit(EditBookDisplayRequest editBookDisplayRequest)
        {
            Book book = _bookRepository.FindBy(editBookDisplayRequest.BookId);

            EditBookDisplayResponse editBookDisplayResponse = new EditBookDisplayResponse();
            editBookDisplayResponse.Book = book.ConvertToEditBookViewModel();

            return editBookDisplayResponse;
        }

        public void EditBook(EditBookRequest editBookRequest)
        {
            Book book = _bookRepository.FindBy(editBookRequest.Id);

            if (editBookRequest.Cover.ContentLength != 0)
            {
                BookCoverFileUtility.DeleteCover(book.FileName);

                book.FileName = BookCoverFileUtility.SaveCover(editBookRequest.Cover);
            }

            book.Title = editBookRequest.Title;
            book.Price = editBookRequest.Price;

            _bookRepository.Update(book);
        }
    }
}