using LibraryManagementCs2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementCs2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        BookDBContext obj = new BookDBContext();
        public ActionResult Index()
        {
            
            List<Book> bk = obj.Books.ToList();

            return View(bk);
        }
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book b)
        {
            obj.Books.Add(b);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {
            Book bo=obj.Books.Single(b => b.Id == id);
            return View(bo);
        }
        [HttpPost]
        public ActionResult Edit(Book b)
        {
            Book bo = obj.Books.First(B => B.Id == b.Id);
            bo.name = b.name;
            bo.nameOfAuthor = b.nameOfAuthor;
            bo.dateOfReturning = b.dateOfReturning;
            bo.dateIssuedOn = b.dateIssuedOn;
            obj.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id) {
            Book b = obj.Books.First(bo => bo.Id == id);
            obj.Entry(b).State = EntityState.Deleted;
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}