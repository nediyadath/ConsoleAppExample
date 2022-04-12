using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class EcomCategory
    {
        public int id { get; set; }
        [Display(Name ="Category Name")]
        public string name { get; set; }
        public string desc { get; set; }

        public string photoPath { get; set; }
    }

    public class Food
    {
        public int id { get; set; }
        [ForeignKey("categ")]

        public int categID { get; set; }

        public EcomCategory categ { get; set; }
        [Display(Name ="Food Name")]
        public string name { get; set; }
        public string desc { get; set; }
        public string photoPath { get; set; }
        public bool check { get; set; }
    }

    public class Cart
    {
        public int id { get; set; }
        [ForeignKey("fd")]
        public int foodID { get; set; }
        public Food fd { get; set; }
        public int qty { get; set; }
        public float price { get; set; }
        public string eMail { get; set; }
        public DateTime orderDate { get; set; }
    }

    public class EcomContext: DbContext
    {
        public DbSet<EcomCategory> category { get; set; }
        public DbSet<Food> food { get; set; }
        public DbSet<Cart> cart { get; set; }
    }
}