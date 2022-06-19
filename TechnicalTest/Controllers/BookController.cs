using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechnicalTest.Context;
using TechnicalTest.Models;
using TechnicalTest.ViewModel;

namespace TechnicalTest.Controllers
{
    public class BookController : Controller
    {
        private DataContext dataContext = new DataContext();
        // GET: Book
        [HttpGet]
        public ActionResult Index()
        {
            var result = dataContext.TblBooks.ToList();
            List<BookVM> data = result.Select(x => new BookVM
            {
                BookId = x.BookId,
                BookName = x.BookName,
                Author = x.Author,
                ReleaseYear = x.ReleaseYear,
                CreatedDate = x.CreatedDate
            }).ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() 
        {
            BookVM data = new BookVM();
            return View(data);
        }
        [HttpPost]
        public ActionResult Create(BookVM vm)
        {
            if (ModelState.IsValid) 
            {
                TblBook data = new TblBook
                {
                    BookName = vm.BookName,
                    Author = vm.Author,
                    ReleaseYear = vm.ReleaseYear,
                    CreatedDate = DateTime.Now
                };
                dataContext.TblBooks.Add(data);
                dataContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var result = dataContext.TblBooks
                .Where(x => x.BookId == id)
                .FirstOrDefault();

            BookVM data = new BookVM
            {
                BookId = result.BookId,
                BookName = result.BookName,
                Author = result.Author,
                ReleaseYear = result.ReleaseYear,
            };
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(BookVM vm)
        {
            if (ModelState.IsValid)
            {
                var data = dataContext.TblBooks
                    .Where(x => x.BookId == vm.BookId)
                    .FirstOrDefault();

                data.BookName = vm.BookName;
                data.Author = vm.Author;
                data.ReleaseYear = vm.ReleaseYear;

                dataContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(vm);
        }
        public ActionResult Delete(int id)
        {
            var result = dataContext.TblBooks
                .Where(x => x.BookId == id)
                .FirstOrDefault();

            dataContext.TblBooks.Remove(result);
            dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}