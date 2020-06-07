using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Model
{
    public class CClass
    {
        public List<Product> Products { get; set; }
        public CClass()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
