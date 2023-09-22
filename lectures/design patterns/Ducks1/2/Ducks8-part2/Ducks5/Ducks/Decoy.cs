using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class Decoy : Duck
    {
        public Decoy(string id)
        {
            Name = id;
            quackStrategy = new QuackSilent();
            swimStrategy = new SwimLikeFloat();
            flyStrategy = new FlyNot();
        }
    }
}
