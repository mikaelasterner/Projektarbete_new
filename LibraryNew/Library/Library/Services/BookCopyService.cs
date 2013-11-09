using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class BookCopyService : IService
    {
        IRepository<BookCopy, int> _bookCopyRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public BookCopyService(IRepository<BookCopy, int> repository)
        {
            _bookCopyRepository = repository;
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
