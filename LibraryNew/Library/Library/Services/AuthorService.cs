using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class AuthorService : IService
    {

        IRepository<Author, int> _AuthorRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public AuthorService(IRepository<Author, int> repository)
        {
            _AuthorRepository = repository;
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

        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}
