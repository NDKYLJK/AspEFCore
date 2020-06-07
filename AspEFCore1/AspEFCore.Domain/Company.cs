using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    //建立多对多关系一个城市多公司一个公司可以再多城市
    public class Company
    {
        public Company()
        {
            CityCompanies = new List<CityCompany>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EstablishDate { get; set; }
        public string Legaperson { get; set; }

        public List<CityCompany>CityCompanies { get; set; }
    }
}
