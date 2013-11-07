using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class BookService
    {
        BookRepository _bookRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public BookService(RepositoryFactory repositoryFactory)
        {
            _bookRepository = repositoryFactory.GetBookRepository();
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        //utlös eventet för att lägga till en bok
        }

        public void Remove(Book book)
        {
            _bookRepository.Remove(book);
            //utlös eventet för att lägga till en bok
        }
    }
}
