using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks1
{
    internal class Quack : IQuackStrategi
    {
        public void doQuack()
        {
            Console.WriteLine("Kvæk kvæk");
        }
    }
}
