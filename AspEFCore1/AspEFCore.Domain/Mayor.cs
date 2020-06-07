using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class Mayor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        //性别是新建的一个类
        public Gender Gender { get; set; }
        public City City { get; set; }

        //每个市长有一个外键为CityId
        //城市必须有，市长是可以选择的
        public int  CityId { get; set; }

    }
}
