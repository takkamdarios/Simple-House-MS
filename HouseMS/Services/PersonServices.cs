using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMS.Models;

namespace HouseMS.Services
{
    internal class PersonServices :Person, IApartmentService
    {
        public void Display()
        {
            Console.WriteLine("Je m'appele {0}.", name);
            house.Display();
        }
    }
}
