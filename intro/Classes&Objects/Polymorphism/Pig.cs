using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Pig: Animal
    {
        public Pig(string type) 
        {
            this.type = type;//inherited from base
        }
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
        //OVERRIDE method: inherited but changed by class.
        public override void Diet()
        {
            base.Diet();
            Console.WriteLine("It eats: everything!");
        }
    }
}
