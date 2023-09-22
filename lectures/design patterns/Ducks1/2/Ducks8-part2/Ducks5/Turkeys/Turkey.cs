using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public abstract class Turkey
    {
        public IFlyStrategy flyStrategy { get; protected set; }
        public IGoobleStrategy goobleStrategy { get; protected set; }
        public ISwimStrategy swimStrategy { get; protected set; }

        public string Name { get; protected set; }
    }
}
