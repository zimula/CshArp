namespace PolyCatnDog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list to store objects. 
            List<Animal> animals = new List<Animal>();

            //inject some objects. 
            animals.Add(new Cat("m","cat"));
            animals.Add(new Cat("j", "cat"));
            animals.Add(new Cat("k", "cat"));
            animals.Add(new Dog("l", "dog"));
            animals.Add(new Dog("n", "dog"));
            animals.Add(new Dog("o","dog"));

            //iterate
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                animal.makeSound();
            }
        }
    }
}