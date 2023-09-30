using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.interfaces
{
    interface IAnimal
    {
        //public by default
        //methods have no bodies, provided by derived classes. 
        void AnimalSound();
        void Run();
    }
}
