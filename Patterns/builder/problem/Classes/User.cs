using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace problem
{
    public class User
    {
        public string name { private get; set; }
        public int? age { private get; set; }
        public string? email { private get; set; }
        public string? phone { private get; set; }
        public string? address { private get; set; }
        public bool CanDrive { get { return age >= 18; } }

        public User(string name)
        {
            this.name = name;
        }
        public User(string name, int? age)
        {
            this.name = name;
            this.age = age;
        }
        public User(string name, int? age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
        public User(string name, int? age, string email, string phone)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.phone = phone;
        }
        public User(string name, int? age, string email, string phone, string address)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

    }

}