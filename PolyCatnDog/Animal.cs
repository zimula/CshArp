using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyCatnDog
{
    abstract class Animal
    {
        public string name;

        
        public abstract void makeSound();
        public abstract void toString();
    }
}
