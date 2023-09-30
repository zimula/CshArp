using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            Mallard graaand = new Mallard("Gråand");
            HelperDuck(graaand);

            ReadHeadDuck readHead = new ReadHeadDuck("Rødand");
            HelperDuck(readHead);

            Greenwing krikAnd = Greenwing.GetInstance();
            HelperDuck(krikAnd);
            //Singleton applied to see if it's limited to one duck. 
            Greenwing krikAnd2 = Greenwing.GetInstance();
            HelperDuck(krikAnd);

            Widgeon pibeAnd = new Widgeon("Pibeand");
            HelperDuck(pibeAnd);

            RubberDuck gummiAnd = new RubberDuck("Gummiand");
            HelperRubber(gummiAnd);

            Decoy lokkeAnd = new Decoy("Lokkeand");
            HelperDecoy(lokkeAnd);

            WildTurkey wildTurkey = new WildTurkey("Vild Kalkun");
            HelperTurkey(wildTurkey);

            TurkeyToDuckAdapter turkeyToDuckAdapter = new TurkeyToDuckAdapter(wildTurkey);
            HelperDuck(turkeyToDuckAdapter);

            Console.ReadLine();
        }

        static void HelperDuck(Duck duck)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(duck.Name);
            Console.ForegroundColor = ConsoleColor.Black;
            duck.DoQuack();
            duck.DoSwim();
            duck.DoFly();
            Console.WriteLine("-------------");
        }

        static void HelperTurkey(Turkey turkey)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(turkey.Name);
            Console.ForegroundColor = ConsoleColor.Black;
            turkey.goobleStrategy.DoGooble();
            turkey.swimStrategy.DoSwim();
            turkey.flyStrategy.DoFly();
            Console.WriteLine("-------------");
        }
        static void HelperDecoy(Decoy decoy)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(decoy.Name);
            Console.ForegroundColor = ConsoleColor.Black;
            decoy.quackStrategy.DoQuack();
            decoy.swimStrategy.DoSwim();
            decoy.flyStrategy.DoFly();
            Console.WriteLine("-------------");
        }

        static void HelperRubber(RubberDuck rubberDuck)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(rubberDuck.Name);
            Console.ForegroundColor = ConsoleColor.Black;
            rubberDuck.quackStrategy.DoQuack();
            rubberDuck.swimStrategy.DoSwim();
            rubberDuck.flyStrategy.DoFly();
            Console.WriteLine("-------------");
        }
    }
}
