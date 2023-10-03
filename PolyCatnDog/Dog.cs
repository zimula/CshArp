using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyCatnDog
{
    internal class Dog:Animal
    {
        public string breed { get; set; }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        public override void makeSound()
        {
            Console.WriteLine("woof");
        }
        public override void toString()
        {
            Console.WriteLine(this.name + "is a dog");
        }

    }
}
