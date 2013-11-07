using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class BookRepository //: IRepository<Book, int>
    {
        LibraryContext _context;

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

      //  public Book Find(Tid id)
        //{
          //  Book bok = null;
            //hittar en bok
           // return bok;

        //}
        public void Edit(Book item)
        {
            //uppdaterar en book
        }
       // public IEnumerable<Book> All()
        //{
        //    
        //    //returnerar en lista med alla element
        //    return books;
        //}
    }
}
