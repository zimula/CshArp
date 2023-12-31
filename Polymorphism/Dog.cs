﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog: Animal
    {
        public Dog(string type) 
        {
            this.type = type;//inherited from base. 
        }
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
        //OVERRIDE method: inherited but changed by class.
        public override void Diet()
        {
            base.Diet();
            Console.WriteLine("It eats: meat!");
        }
    }
}
