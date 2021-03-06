﻿using BookStore.Data.Interface;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookStoreContext _bookStoreContext;
        public BookRepository(BookStoreContext storeContext)
        {
            _bookStoreContext = storeContext;
        }

        public IEnumerable<Book> Books => _bookStoreContext.Books.Include(f => f.Category);
        //public Book Book => _bookStoreContext;

        public Book GetBookById(int id) => _bookStoreContext.Books.FirstOrDefault(p => p.Id == id);
        public Category GetCategory(int id) => _bookStoreContext.Books.FirstOrDefault(p => p.Id == id).Category;

        public void Add(Book book)
        {
            _bookStoreContext.Add(book);
            _bookStoreContext.SaveChanges();
        }

    }
}
