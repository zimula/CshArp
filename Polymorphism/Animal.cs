using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //parent class, all animals will inherit from this class.
    class Animal
    {
        public string? type;
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        //VIRTUAL method: lets derived class modify. 
        public virtual void Diet()
        {
            Console.WriteLine("The animal eats something.");
        }
    }
}
