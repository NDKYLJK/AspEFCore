using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class AspEFCore1
    {

        public List<City> Cities { get; set; }
        public AspEFCore1()
        {
            Cities = new List<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
