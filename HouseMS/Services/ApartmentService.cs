using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseMS.Models;

namespace HouseMS.Services
{
    internal class ApartmentService:House
    {
        public ApartmentService(int surface) : base(surface)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Je suis un appartement, ma surface est " + surface + " m2");
        }
    }
}
