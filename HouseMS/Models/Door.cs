using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMS.Services;

namespace HouseMS.Models
{
    internal class Door
    {
        public string color { get; set; }
        public Door()
        {
            color = "pink";
        }

        public Door(string color)
        {
            this.color = color;
        }

    }
}
