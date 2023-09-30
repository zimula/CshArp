namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig("Pig");
            Animal myDog = new Dog("Dog");
            Pig myPig2 = new Pig("Pig");
            Dog myDog2 = new Dog("Dog");

            //testing fields
            Console.WriteLine("This animal is a " + myPig.type);
            Console.WriteLine("This animal is a " + myDog.type);

            //instantiate via base class: displays the sound created in the base class. 
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            //test on virtual/override method
            myPig.Diet();
            myDog.Diet();
            //instatiated via derived class: displays the sound created in the inherited class. 
            myPig2.animalSound();
            myDog2.animalSound();
            //with virtual methods it does't matter how you instantiate
            //also gets rid of the inheritance error. 
        }
    }
}