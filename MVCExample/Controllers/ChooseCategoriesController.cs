using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    [Authorize]
    public class ChooseCategoriesController : Controller
    {
        EcomContext db = new EcomContext();
        // GET: ChooseCategories
        public ActionResult Index()
        {
            return View(db.category.ToList());
        }

        public ActionResult GetFood(int id)
        {
            return View(db.food.Include("categ").Where(e => e.categID == id).ToList());
        }

        [HttpPost]
        public ActionResult GetFood(List<Food> flist)
        {
            foreach (Food f in flist)
            {
                if (f.check)
                {
                    Cart c = new Cart();
                    c.foodID = f.id;
                    c.price = 100;
                    c.qty = 5;
                    c.orderDate = DateTime.Now;
                    c.eMail = HttpContext.User.Identity.Name;
                    db.cart.Add(c);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}