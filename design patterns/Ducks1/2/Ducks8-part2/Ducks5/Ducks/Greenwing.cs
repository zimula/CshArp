using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ducks
{
    public class Greenwing : Duck
    {
        //Applying singleton to the greenwing class.
        static private Greenwing Instance;
        //Make it impossible to create more than one greenwing. 
        //Make constructor private and introduce a new public method to deal with the intantiation.
        private Greenwing(string id)
        {
            Name = id;
            quackStrategy = new QuackLikeDuck();
            swimStrategy = new SwimLikeDuck();
            flyStrategy = new FlyWithWings();
        }
        static public Greenwing GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Greenwing("Krikand");
            }
            return Instance;
        }
    }
}
