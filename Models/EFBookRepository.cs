﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMorey.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDBContext _context;

        //Constructor
        public EFBookRepository(BookDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
