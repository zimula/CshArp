namespace Abstraction
{
    using Abstraction.Animals;
    using Abstraction.Pigs;
    

    internal class Program
    {
       
        static void Main(string[] args)
        {
            //testin abstract method. 
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.Sleep();
            
        }
    }
}