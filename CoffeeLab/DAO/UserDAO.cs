using CoffeeLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeLab.DAO
{
    public class UserDAO
    {
        public static void AddUser(User data)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            ORM.Users.Add(data);
            ORM.SaveChanges();
        }
    }
}