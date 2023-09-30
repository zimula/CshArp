using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Vehicle
    {
        //This is the parent class. 
        public string brand = "Ford";
        public void Honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
