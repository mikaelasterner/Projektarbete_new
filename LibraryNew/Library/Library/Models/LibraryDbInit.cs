using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Library.Services;
using Library.Repositories;
namespace Library.Models
{
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);
            // seeding data goes here..
            RepositoryFactory repositoryFactory = new RepositoryFactory();

            BookService _bookservice = new BookService(repositoryFactory.GetBookRepository());
            AuthorService _authorservice = new AuthorService(repositoryFactory.GetAuthorRepository());
            BookCopyService _bookCopyService = new BookCopyService(repositoryFactory.GetBookCopyRepository());
            MemberService _memberservice = new MemberService(repositoryFactory.GetMemberRepository());
            LoanService _loanservice = new LoanService(repositoryFactory.GetLoanRepository());


            _bookservice.Add(new Book() { Title = "TEST", Author = new Author() { Name = "Dennis" }, Description = "None", ISBN = "1337" });
            Author a = new Author() { Name = "Anders Svensson" };
            _authorservice.Add(a);
            _bookservice.Add(new Book() { Title = "Mordet på greven", ISBN = "23329", Author = a });
            _bookservice.Add(new Book() { Title = "Mordet på Liselott", ISBN = "26629", Author = new Author { Name = "Gösta Ekman" } });
            _bookservice.Add(new Book() { Title = "Greven", ISBN = "98329" });
            _bookCopyService.Add(new BookCopy() { Book = new Book { Title = "Den första bokkopian", ISBN = "88629", Author = new Author { Name = "Yngve Ekman" } } });
            

        }
    }
}
