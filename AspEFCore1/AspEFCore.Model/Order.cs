using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Model
{
    public class Order
    {

        public List<OrderProduct> OrderProducts { get; set; }
        public List<OrderUser> OrderUsers { get; set; }
        public Order()
        {
            OrderProducts = new List<OrderProduct>();
            OrderUsers = new List<OrderUser> ();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Product Prodeuct { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

    }
}
