﻿
using ServiceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class BookService
    {
        private readonly List<Book> _book;
        public BookService()
        {
            _book = new List<Book>() { 
              new Book() { Id = 1 , Title = "Book1" , Author = "Kishan" , Genre ="First"},
              new Book() { Id = 2 , Title = "Book2" , Author = "Kishan" , Genre ="First"}
            };

        }

        public List<Book> GetAll()
        {
            return _book;
        }

        public Book GetById(int id)
        {
            return _book.First(x => x.Id == id);
        }

        public List<Book> InsertBook(Book book)
        {
            _book.Add(book);
            return _book;
        }

    }
}
