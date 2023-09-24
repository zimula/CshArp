using Interfaces.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Pigs
{
    //this class inherits from multiple interfaces. 
    class Pig: IAnimal, ILiving
    {
       

        public void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
        public void Run()
        {
            Console.WriteLine("Pigs run very fast");
        }
        public void SignOfLife()
        {
            Console.WriteLine("I'm alive!");
        }
    }
}
