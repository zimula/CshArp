using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck(string id)
        {
            Name = id;
            quackStrategy = new QuackLikeRuber();
            swimStrategy = new SwimLikeFloat();
            flyStrategy = new FlyNot();
        }
    }
}
