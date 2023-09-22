using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Gooble : IGoobleStrategy
    {
        public void DoGooble()
        {
            Console.WriteLine("pludrer");
        }
    }
}
