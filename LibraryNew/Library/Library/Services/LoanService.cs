using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class LoanService
    {
        LoanRepository _LoanRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public LoanService(RepositoryFactory repositoryFactory)
        {
            _LoanRepository = repositoryFactory.GetLoanRepository();
        }

        public void Add(Loan loan)
        {
            _LoanRepository.Add(loan);
        //utlös eventet för att lägga till en bok
        }

        public void Remove(Loan loan)
        {
            _LoanRepository.Remove(loan);
            //utlös eventet för att lägga till en bok
        }
    }
}
