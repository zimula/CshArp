using Ducks1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ducks
{
    public class Duck
    {
        public string Name {get; set; }
        //strategies made from interfaces and classes.  
        public ISwimStrategi swimLikeaDuck { protected get; set; }
        public IdiveStrategi diveLikeaDuck { protected get; set;}
        public IQuackStrategi quackLikeaDuck { protected get; set; }
        //turn strategies protected and pass them through methods. 



        /*public void Swim()
        {
            Console.WriteLine("Svømmer");
        }*/

        //add flying method
        virtual public void Fly()
        {
            Console.WriteLine("Flyver");
        }
    }

    public class Mallard : Duck
    {
        public Mallard(string id)
        {
            Name = id;
            swimLikeaDuck = new Swim();
            quackLikeaDuck = new Quack();
        }
    }

    public class ReadHeadDuck : Duck
    {
        public ReadHeadDuck(string id)
        {
            Name = id;
            swimLikeaDuck = new Swim();
            quackLikeaDuck = new Quack();

        }
    }
    public class Greenwing : Duck
    {
        public Greenwing(string id)
        {
            Name = id;
            swimLikeaDuck = new Swim();
            quackLikeaDuck = new Quack();
        }

    }
    public class Widgeon: Duck
    {
        public Widgeon(string id)
        {
            Name= id;
            swimLikeaDuck = new Swim();
        }

    }

    public class Rubberduck : Duck
    {
        public Rubberduck(string id)
        {
            Name = id;
            swimLikeaDuck = new Swim();
        }
        /*public override void Quack()
        {
            Console.WriteLine("Piv Piv");
        }*/
        public override void Fly()
        {
            
        }

    }
    public class Decoy : Duck
    {
        public Decoy(string id)
        {
            Name = id;
            swimLikeaDuck = new NoSwim();
        }
        
    }
}
