using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMS.Services
{
    internal class HouseServices 
    {
        public int surface { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("Je suis une maison, ma surface est de {0} m2.", surface);
        }
    }
}
