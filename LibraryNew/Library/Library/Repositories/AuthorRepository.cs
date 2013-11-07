using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }
        public void Add(Author item)
        {
            //sparar authorn i databasen
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }

    }
}
