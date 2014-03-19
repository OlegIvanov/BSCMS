﻿using System;
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
            string fileName = BookCoverFileUtility.SaveCover(addBookRequest.Cover);

            Book book = new Book
            {
                Title = addBookRequest.Title,
                Price = addBookRequest.Price,
                FileName = fileName
            };

            _bookRepository.SaveBook(book);
        }

        public BookListResponse GetBookList()
        {
            BookListResponse bookListResponse = new BookListResponse();

            IList<Book> books = _bookRepository.FindAll();

            bookListResponse.Books = books.ConvertToBookListViewModel();

            return bookListResponse;
        }

        public void DeleteBook(DeleteBookRequest deleteBookRequest)
        {
            _bookRepository.DeleteBook(deleteBookRequest.BookId);
        }
    }
}
