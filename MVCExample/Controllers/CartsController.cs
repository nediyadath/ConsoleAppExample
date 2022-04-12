using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class CartsController : Controller
    {
        EcomContext db = new EcomContext();
        // GET: Carts
        public ActionResult Index()
        {
            var clist = db.cart;
            return View(clist.Include("fd").ToList());
        }

        public ActionResult Create()
        {
            ViewBag.foodID = new SelectList(db.food, "id", "name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cart c )
        {
            if (ModelState.IsValid)
            {
                db.cart.Add(c);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.foodID = new SelectList(db.food, "id", "name");
            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.foodID = new SelectList(db.food, "id", "name");
            Cart c = db.cart.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Cart c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.foodID = new SelectList(db.food, "id", "name");
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(db.cart.Find(id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.cart.Find(id));
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            db.cart.Remove(db.cart.Find(id));
            db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}