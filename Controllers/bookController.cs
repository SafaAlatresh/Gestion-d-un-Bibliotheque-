using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books_Mangement_using_MVC.Models;

namespace Books_Mangement_using_MVC.Controllers
{
    public class bookController : Controller
    {

        private static List<Book > books;

        // GET: book
        public ActionResult Index()
        {
            if (books == null)
            {
                books = new List<Book>();
                books.Add(new Book

                {
                    Id = 1,
                    Author = "Vincent le Goff",
                    Title = "Python",
                    Price = 19.9$
                });

                books.Add(new Book

                {
                    Id = 2,
                    Author = "Olivier Hondermarck",
                    Title = " Tout Java script ",
                    Price = 29.90$
                });

                books.Add(new Book

                {
                    Id = 3,
                    Author = "Lê Nguyên Hoang, El Mahdi el Mhamdi",
                    Title = " Le fabuleux chantier ",
                    Price = 39.00$
                });


                books.Add(new Book

                {
                    Id = 3,
                    Author = "Lê Nguyên Hoang, El Mahdi el Mhamdi",
                    Title = " Le fabuleux chantier ",
                    Price = 39.00$
                });

                books.Add(new Book

                {
                    Id = 4,
                    Author = "Dominique Paret, Hassina Rebaine",
                    Title = " Véhicules autonomes et connectés ",
                    Price = 70.00$
                });


            }
            return View(books);
        }

        // GET: book/Details/5
        public ActionResult Details(int id)
        {
            Book book = books.Single(s => s.Id == id);
            return View(book);
        }

        // GET: book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here

                books.Add(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: book/Edit/5
        public ActionResult Edit(int id)
        {
            Book book = books.Single(a => a.Id == id);

            return View(book);
        }

        // POST: book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book )
        {
            try
            {
                // TODO: Add update logic here

                Book oldbook = books.Single(a => a.Id == id);
                oldbook.Author = book.Author;
                oldbook.Title = book.Title;
                oldbook.Price = book.Price; 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: book/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = books.Single(a => a.Id == id);

            return View(books);
        }

        // POST: book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                Book book = books.Single(a => a.Id == id);
                books.Remove(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
