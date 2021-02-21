﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMorey.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
