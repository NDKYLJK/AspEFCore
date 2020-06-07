using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Model
{
    public class OrderUser
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public int UserId { get; set; }
      //  public Order Orders { get; set; }
      //  public User Users { get; set; }
    }
}
