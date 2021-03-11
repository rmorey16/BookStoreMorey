using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMorey.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book book, int quantity)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookID == book.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }

        }

        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookID == book.BookID);

        public virtual void Clear() => Lines.Clear();

        public double ComputeTotalSum() 
        {
            return(Lines.Sum(e => e.Book.Price * e.Quantity));
        }
            

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
