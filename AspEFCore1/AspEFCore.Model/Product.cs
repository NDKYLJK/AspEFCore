using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Model
{
    public class Product
    {
        public List<Order> Orders { get; set; }
        public List<ProductCClass> ProductCClasss { get; set; }
        public Product()
        {
            Orders = new List<Order>();
            ProductCClasss = new List<ProductCClass>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public CClass CClass { get; set; }
        public int CClassId { get; set; }

    }
}
