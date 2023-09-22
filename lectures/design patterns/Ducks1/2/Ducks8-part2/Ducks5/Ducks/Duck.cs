using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public abstract class Duck
    {
        public IFlyStrategy flyStrategy { private get; set; }
        public IQuackStrategy quackStrategy { private get; set; }
        public ISwimStrategy swimStrategy { private get; set; }

        public string Name { get; protected set; }

        virtual public void DoFly()
        {
            flyStrategy.DoFly();
        }
        virtual public void DoQuack()
        {
            quackStrategy.DoQuack();
        }
        virtual public void DoSwim()
        {
            swimStrategy.DoSwim();
        }
    }
}
