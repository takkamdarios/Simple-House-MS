using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMS.Services;

namespace HouseMS.Models
{
    internal  class House 
    {
        public int surface { get; set; }
        public Door door { get; set; }
        public House(int surface)
        {
            this.surface = surface;
            door = new Door();
        }

        public virtual void Display()
        {
            Console.WriteLine("Je suis une maison, ma surface est de {0} m2.", surface);
        }
    }
}
