using Ducks5.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class Decoy : DuckAttrap
    {
        public Decoy(string id)
        {
            Name = id;
            quackStrategy = new QuackSilent();
            swimStrategy = new SwimNot();
            flyStrategy = new FlyNot();
        }
    }
}
