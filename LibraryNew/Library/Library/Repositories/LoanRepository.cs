using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Loan loan)
        {
            //sparar bok i databasen
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void Remove(Loan loan)
        {
            _context.Loans.Remove(loan);
            _context.SaveChanges();
        }

        public Loan Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Loan item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan> All()
        {
            throw new NotImplementedException();
        }
    }
}
