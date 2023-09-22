using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class WildTurkey : Turkey
    {
        public WildTurkey(string id)
        {
            Name = id;
            goobleStrategy = new Gooble();
            swimStrategy = new SwimNot();
            flyStrategy = new FlyShort();
        }
    }
}
