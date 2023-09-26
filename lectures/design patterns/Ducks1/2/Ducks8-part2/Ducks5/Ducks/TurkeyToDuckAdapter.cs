using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ducks
{
    public class TurkeyToDuckAdapter : Duck
    {
        private Turkey turkey;
        public TurkeyToDuckAdapter(Turkey turkey)
        {
            this.turkey = turkey;
            Name = turkey.Name;
        }

        public override void DoQuack()
        {
            turkey.goobleStrategy.DoGooble();
        }
        public override void DoSwim()
        {
            turkey.swimStrategy.DoSwim();
        }
        public override void DoFly()
        {
            turkey.flyStrategy.DoFly();
            turkey.flyStrategy.DoFly();
            turkey.flyStrategy.DoFly();
        }
    }
}
