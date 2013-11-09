using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class BookService : IService
    {
        readonly IRepository<Book, int> _bookRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public BookService(IRepository<Book,int> repository)
        {
            _bookRepository = repository;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        //utlös eventet för att lägga till en bok
        }

        public void Remove(Book book)
        {
            _bookRepository.Remove(book);
            
        }

        public Book Find(int id) {
            return _bookRepository.Find(id);
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
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
