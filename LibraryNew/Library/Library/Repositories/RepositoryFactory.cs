using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class RepositoryFactory
    {
        /// <summary>
        /// Wrapper property to access the context
        /// </summary>
        //static LibraryContext context
        //{
            //get { return ContextSingelton.GetContext(); }
        //}

        public LibraryContext _context;

        public RepositoryFactory()
        {
            _context = ContextSingelton.GetContext();
        }

        // add factory methods for your repositories here..
        public BookRepository GetBookRepository()
        {
            return new BookRepository(_context);
        }

        public AuthorRepository GetAuthorRepository()
        {
            return new AuthorRepository(_context);
        }

        public BookCopyRepository GetBookCopyRepository()
        {
            return new BookCopyRepository(_context);
        }

        public MemberRepository GetMemberRepository()
        {
            return new MemberRepository(_context);
        }

        public LoanRepository GetLoanRepository()
        {
            return new LoanRepository(_context);
        }
    }
}
