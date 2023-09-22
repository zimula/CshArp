using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class Greenwing : Duck
    {
        public Greenwing(string id)
        {
            Name = id;
            quackStrategy = new QuackLikeDuck();
            swimStrategy = new SwimLikeDuck();
            flyStrategy = new FlyWithWings();
        }
    }
}
