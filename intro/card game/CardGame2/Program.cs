using System.Net.Security;

namespace CardGame2
{
    /*
     - Typecast: force type change of values.
     - Enum: list of values (basically and object not a class)*/
    public enum Kuloer
    {
        Spade, 
        Clover,
        Diamonds, 
        Hearts
    }
    public enum Rank
    {
        Ace,
        Two, 
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack, 
        Queen,
        King
    }
    class Card
    {

        //field to hold card values
        Kuloer kuloer;
        Rank rank;
        //randominzing
        static Random Random = new Random();
        //constructor to instantiate
        public Card(Kuloer kuloer, Rank rank)
        {
            this.kuloer = kuloer;
            this.rank = rank;   
        }
        //method to display card
        public string displayCard()
        {
            return $"{rank} of {kuloer}";
        }
        //method to pick random card
        public string CardRan()
        {
            //random cards. 
            return "I'm your random card";
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enum Test");
             Kuloer test = Kuloer.spar;
             Console.WriteLine(test);
             //typecast: display position of enum
             Console.WriteLine((int)test);*/
            Card test = new Card(Kuloer.Spade,Rank.Nine);
            Console.WriteLine("Testing");
            Console.WriteLine(test.displayCard() + "testing");
            Console.ReadLine();
            //display entire deck
            foreach (int i in Enum.GetValues(typeof(Kuloer)))
            {
                foreach (int y in Enum.GetValues(typeof(Rank)))
                {
                    Card k = new Card((Kuloer)i, (Rank) y);
                    //Console.WriteLine($"{(Kuloer) i} {(Rank) y}");
                    Console.WriteLine("The entire deck");
                    Console.WriteLine(k.displayCard());
                }
            }
        }
    }
}