using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMS.Services;

namespace HouseMS.Models
{
    internal class Person
    {
        public House house { get; set; }
        public string name { get; set; }

        public Person()
        {
            name = "Peter";
            house = new House(30);
        }
        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
        
    }
}
