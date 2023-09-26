using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks5
{
    internal class Rubber2Duck: Duck
    {
        private RubberDuck rubberDuck;
        public Rubber2Duck(RubberDuck rubberDuck)
        {
            this.rubberDuck = rubberDuck;
            Name = rubberDuck.Name;

        }
        public override void DoQuack()
        {
            rubberDuck.quackStrategy.DoQuack();
        }
        public override void DoSwim()
        {
            rubberDuck.swimStrategy.DoSwim();
        }
        public override void DoFly()
        {
            rubberDuck.flyStrategy.DoFly();
        }
    }

}
