using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreMorey.Infastructure;
using BookStoreMorey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStoreMorey.Pages
{
    public class BuyModel : PageModel
    {
        private IBookRepository repository;

        //constructor
        public BuyModel (IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookID == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookID == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.RemoveLine(book);

            HttpContext.Session.SetJson("cart", Cart);

            //Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookID == bookId).Book);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
