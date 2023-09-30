using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks5.Ducks
{
    public abstract class DuckAttrap
    {
        public IFlyStrategy flyStrategy {get; set; }
        public IQuackStrategy quackStrategy {get; set; }
        public ISwimStrategy swimStrategy {get; set; }
        public string Name { get; set; }

    }
}
