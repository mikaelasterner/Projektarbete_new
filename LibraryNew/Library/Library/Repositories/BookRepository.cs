using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class BookRepository : IRepository<Book, int>
    {
        readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Book item)
        {
            //sparar bok i databasen
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Book item)
        {
            _context.Books.Remove(item);
            _context.SaveChanges();
        }

        public Book Find(int bookId)
        {
            Book book = _context.Books.Find(bookId);
            return book;
        }
        public void Edit(Book newBookData)
        {
            var bookToEdit = Find(newBookData.Id);

            bookToEdit.Title = newBookData.Title;
            bookToEdit.Author = newBookData.Author;
            bookToEdit.Description = newBookData.Description;
            bookToEdit.ISBN = newBookData.ISBN;

            _context.SaveChanges();
        }

        public IEnumerable<Book> All()
        {
            return _context.Books;
        }

    }
}
