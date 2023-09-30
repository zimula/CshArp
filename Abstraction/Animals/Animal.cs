using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Animals
{
    abstract class Animal
    {
        public abstract void animalSound();//abstract method (no body, provided by child).
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}
