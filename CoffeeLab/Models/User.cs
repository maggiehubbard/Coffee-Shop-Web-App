using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeLab.Models
{
    public class User
    {
        //fields
        private string name;
        private int age;
        private string email;
        private string phone;

        //constructor
        public User(string name, int age, string email, string phone)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.phone = phone;
        }

        //no argument constructor
        public User()
        {
            
        }

        //properties
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        
    }
}