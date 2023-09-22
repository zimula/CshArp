using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class FlyWithWings : IFlyStrategy
    {
        public void DoFly()
        {
            Console.WriteLine("Flyver med vinger");
        }
    }
}
