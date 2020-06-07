using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{

    public class City
    {

        public City()
        {
            CityCompanies = new List<CityCompany>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AreaCode { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        //用于检测
        public AspEFCore1 AspEFCore1 { get; set; }
        public List<CityCompany>CityCompanies { get; set; }

        //添加一对一导航，每个城市只有一个市长
        public Mayor Mayor { get; set; }

    }
}
