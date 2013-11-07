using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class BookCopyService
    {
        BookCopyRepository _bookCopyRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public BookCopyService(RepositoryFactory repositoryFactory)
        {
            _bookCopyRepository = repositoryFactory.GetBookCopyRepository();
        }

        public void Add(BookCopy copy)
        {
            _bookCopyRepository.Add(copy);
        //utlös eventet för att lägga till en bok
        }

        public void Remove(BookCopy copy)
        {
            _bookCopyRepository.Remove(copy);
            //utlös eventet för att lägga till en bok
        }
    }
}
