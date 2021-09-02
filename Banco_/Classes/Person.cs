using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_
{
    public class Person : Ipersonable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Code { get; set; }

        public Person(string Name, int Age, int Code )
        {
            this.Name = Name;
            this.Age = Age;
            this.Code = Code;
            
        }

        public Person()
        {

        }

    }
}
