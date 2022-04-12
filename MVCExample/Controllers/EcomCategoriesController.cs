using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    [Authorize(Roles ="admin")]
    public class EcomCategoriesController : Controller
    {
        private EcomContext db = new EcomContext();

        // GET: EcomCategories
        public ActionResult Index()
        {
            return View(db.category.ToList());
        }

        // GET: EcomCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcomCategory ecomCategory = db.category.Find(id);
            if (ecomCategory == null)
            {
                return HttpNotFound();
            }
            return View(ecomCategory);
        }

        // GET: EcomCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EcomCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,desc,photoPath")] EcomCategory ecomCategory)
        {
            if (ModelState.IsValid)
            {
                db.category.Add(ecomCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ecomCategory);
        }

        // GET: EcomCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcomCategory ecomCategory = db.category.Find(id);
            if (ecomCategory == null)
            {
                return HttpNotFound();
            }
            return View(ecomCategory);
        }

        // POST: EcomCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,desc,photoPath")] EcomCategory ecomCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ecomCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ecomCategory);
        }

        // GET: EcomCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcomCategory ecomCategory = db.category.Find(id);
            if (ecomCategory == null)
            {
                return HttpNotFound();
            }
            return View(ecomCategory);
        }

        // POST: EcomCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EcomCategory ecomCategory = db.category.Find(id);
            db.category.Remove(ecomCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
