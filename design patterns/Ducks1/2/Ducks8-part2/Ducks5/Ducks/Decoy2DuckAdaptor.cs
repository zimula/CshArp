using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ducks5.Ducks
{
    internal class Decoy2DuckAdaptor: Duck
    {
        //get decoy object as a property
        private Decoy decoy;
        //a constructor
        public Decoy2DuckAdaptor(Decoy decoy)
        {
            this.decoy = decoy;
            Name = decoy.Name;
        }
        public override void DoQuack()
        {
            decoy.quackStrategy.DoQuack();  
        }
        public override void DoSwim()
        {
            decoy.swimStrategy.DoSwim();
        }
        public override void DoFly()
        {
            decoy.flyStrategy.DoFly();
        }
    }
}
