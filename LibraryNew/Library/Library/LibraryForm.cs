﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Services;
using Library.Repositories;
using System.Data.Entity;

namespace Library
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            BookService _bookservice;
            InitializeComponent();


            // Uncomment the line you wish to use
            // Use a derived strategy with a Seed-method
           Database.SetInitializer<LibraryContext>(new LibraryDbInit());

            // Recreate the database only if the models change
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());

            // Always drop and recreate the database
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseAlways<LibraryContext>());




            //BookRepository bookRepository = new RepositoryFactory().GetBookRepository();
            RepositoryFactory factory = new RepositoryFactory();
            _bookservice = new BookService(factory);


            _bookservice.Add(new Book() { Title = "Mordet på greven", ISBN = "23329" });
            _bookservice.Add(new Book() { Title = "Mordet på Liselott", ISBN = "26629" });
            _bookservice.Add(new Book() { Title = "Geven", ISBN = "98329" });

        }
    }
}