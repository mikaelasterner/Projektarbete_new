using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class AuthorService
    {

        AuthorRepository _AuthorRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public AuthorService(RepositoryFactory repositoryFactory)
        {
            _AuthorRepository = repositoryFactory.GetAuthorRepository();
        }

        public void Add(Author author)
        {
            _AuthorRepository.Add(author);
        //utlös eventet för att lägga till en bok
        }

        public void Remove(Author author)
        {
            _AuthorRepository.Remove(author);
            //utlös eventet för att lägga till en bok
        }
    }
}
