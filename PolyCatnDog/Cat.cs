using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyCatnDog
{
     class Cat:Animal
    {
        public string breed {  get; set; }

        public Cat(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        public override void makeSound()
        {
            Console.WriteLine("meow");
        }
        public override void toString()
        {
            Console.WriteLine(this.name + " is a cat");
        }

    }
}
