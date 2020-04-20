using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is About page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is contact page.";

            return View();
        }
        public ActionResult Products()
        {
            ViewBag.Message = "Products Page";
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book()
            {
                Id = 1,
                Title = "The Gathering Storm",
                Isbn = "123-456"
            });
            bookList.Add(new Book()
            {
                Id = 2,
                Title = "The Lord of the Rings: The Fellowship of the Rings",
                Isbn = "123-457"
            });

            return View(bookList);
        }
    }
}