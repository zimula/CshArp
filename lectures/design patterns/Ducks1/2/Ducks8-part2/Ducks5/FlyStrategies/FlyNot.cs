using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class FlyNot : IFlyStrategy
    {
        public void DoFly()
        {
            Console.WriteLine("Kan ikke flyve");
        }
    }
}
