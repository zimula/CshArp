using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks1
{
    internal class NoSwim : ISwimStrategi
    {
        public void doSwim()
        {
            Console.WriteLine("Synker");
        }
    }
}
