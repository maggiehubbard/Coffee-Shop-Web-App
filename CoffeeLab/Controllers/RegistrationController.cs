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

        public ActionResult Success(string firstname, string lastname, int age, string gender, string phone, string email, string password, bool permission = false)
        {
            ViewBag.FirstName = firstname;
            ViewBag.LastName = lastname;
            ViewBag.Age = age;
            ViewBag.Gender = gender;
            ViewBag.Phone = phone;
            ViewBag.Email = email;
            ViewBag.Password = password;                        
            ViewBag.Permission = permission; //radio button - permission to email special offers

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