using CoffeeLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeLab.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success(User data)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    ORM.Users.Add(data);
                    ORM.SaveChanges();
                    ViewBag.Message = $"Welcome {data.FirstName}! Your acccount was created successfully";
                }
                catch (Exception e)
                {

                    ViewBag.Message = $"Error: {e.Message} occured. Please try creating an account later";

                    //$"{data.Email} was not a valid customer";
                }

            }
            return View();
        }
        public ActionResult Login(string username, string password)
        {
            ViewBag.UserName = username;
            ViewBag.Password = password;
           
            return View();
        }


    }
}