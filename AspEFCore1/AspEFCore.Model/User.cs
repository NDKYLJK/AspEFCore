using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Model
{
    public class User
    {
        public List<Order> Orders { get; set; }
        
        public User()
        {
            Orders = new List<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Passwoed { get; set; }
    }
}
