using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Animals;
namespace Abstraction.Pigs
{
    class Pig: Animal
    {
        //dealing with the abstract method: OVERRIDE
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee!");
        }
    }
}
