using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMS.Models;

namespace HouseMS.Services
{
    internal class DoorServices:Door, IDoorServices
    {
        public void Display()
        {
            Console.WriteLine("Je suis une porte, ma couleur est {0}.", color); 
        }
    }
}
