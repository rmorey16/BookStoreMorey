using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMorey.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFName = "Victor", 
                        AuthorLName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumPages = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFName = "Doris Kearns",
                        AuthorLName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumPages = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFName = "Alice",
                        AuthorLName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumPages = 832
                    },
                    new Book
                    {
                        Title = "America Ulysses",
                        AuthorFName = "Ronald C. ",
                        AuthorLName= "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumPages = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFName = "Laura", 
                        AuthorLName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumPages = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFName = "Michael",
                        AuthorLName= "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Non-Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95, 
                        NumPages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFName = "Cal", 
                        AuthorLName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99, 
                        NumPages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFName = "Michael",
                        AuthorLName= "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66, 
                        NumPages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFName = "Richard",
                        AuthorLName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16, 
                        NumPages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFName = "John",
                        AuthorLName= "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03, 
                        NumPages = 642
                    },
                    new Book
                    {
                        Title = "Way of Kings",
                        AuthorFName = "Brandon",
                        AuthorLName = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Classification = "Fiction",
                        Category = "High fantasy",
                        Price = 9.59, 
                        NumPages = 1007
                    },
                    new Book
                    {
                        Title = "The Amulet of Samarkand",
                        AuthorFName = "Jonathan",
                        AuthorLName = "Stroud",
                        Publisher = "Doubleday",
                        ISBN = "078-6818590000",
                        Classification = "Fiction",
                        Category = "Children's Fantasy",
                        Price = 9.99, 
                        NumPages = 462
                    },
                    new Book
                    {
                        Title = "The Martian",
                        AuthorFName = "Andy",
                        AuthorLName = "Weir",
                        Publisher = "Self Published (2011), Crown (2014)",
                        ISBN = "978-0804139021",
                        Classification = "Fiction",
                        Category = "Sci-Fi",
                        Price = 9.36, 
                        NumPages = 369
                    });
                context.SaveChanges();
            }
        }
    }
}
