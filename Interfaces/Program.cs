using Interfaces.Pigs;
using System.Net.Security;

namespace Interfaces
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.AnimalSound();
            myPig.Run();
            myPig.SignOfLife();
            myLevel f = myLevel.low;
            Console.WriteLine(f);
           
        }
    }
    enum myLevel
    {
        low, 
        medium,
        high
    }
}