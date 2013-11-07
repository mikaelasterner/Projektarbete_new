using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(BookCopy item)
        {
            //sparar bokkopian i databasen
            _context.BookCopies.Add(item);
            _context.SaveChanges();
        }

        public void Remove(BookCopy item)
        {
            _context.BookCopies.Remove(item);
            _context.SaveChanges();
        }

    }
}
