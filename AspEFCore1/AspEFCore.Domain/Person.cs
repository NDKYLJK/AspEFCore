using System;
using System.Collections.Generic;
using System.Text;

namespace AspEFCore.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay{ get; set; }
        //性别是新建的一个类
        public Gender Gender { get; set; }

    }
}
