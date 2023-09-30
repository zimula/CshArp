using Ducks1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation
            Mallard graaand = new Mallard("Gråand");
            Helper(graaand);

            ReadHeadDuck readHead = new ReadHeadDuck("Rødand");
            Helper(readHead);
            //create more ducks. 
            Greenwing greenwing = new Greenwing("Krikand");
            Helper(greenwing);

            Widgeon widgeon = new Widgeon("Pibeand");
            Helper(widgeon);

            Rubberduck rubberduck = new Rubberduck("Gummiand");
            Helper(rubberduck);

            Decoy decoy = new Decoy("Decoy");
            Helper(decoy);

            Turkey turkey = new Turkey("Turkey1");
            Helper1(turkey);

            Console.ReadLine();
        }

        static void Helper(Duck myDuck)
        {
            //add ducks to screen
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(myDuck.Name);
            Console.ResetColor();
            //myDuck.Quack();
            //myDuck.quackLikeaDuck.doQuack();
            //myDuck.Swim(); Replace with with object from strategi
            //myDuck.swimLikeaDuck.doSwim();
            //myDuck.Fly();
            
            
            Console.WriteLine("-------------");
        }
        static void Helper1(Turkey myTurkey)
        {
            //add ducks to screen
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(myTurkey.Name);
            Console.ResetColor();
            myTurkey.gobleLikeaTurkey.doGoble();



            Console.WriteLine("-------------");
        }
    }
}
