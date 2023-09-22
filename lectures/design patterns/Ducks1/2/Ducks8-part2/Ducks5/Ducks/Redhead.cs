using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class ReadHeadDuck : Duck
    {
        public ReadHeadDuck(string id)
        {
            Name = id;

            quackStrategy = new QuackLikeDuck();
            swimStrategy = new SwimLikeDiveDuck();
            flyStrategy = new FlyWithWings();            
        }
    }
}
