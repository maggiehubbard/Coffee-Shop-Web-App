using CoffeeLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Products";
            List<string> Images = new List<string>();
            Images.Add("mug.jpg");
            Images.Add("slippers.jpg");
            Images.Add("stickerpack.jpg");
            Images.Add("headband.jpg");
            Images.Add("shirt.jpg");
            Images.Add("purse.png");
            ViewBag.Images = Images.ToList();
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();   //add items to list      
            ViewBag.Items = ORM.Items.ToList();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}