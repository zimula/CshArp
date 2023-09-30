namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the constructor allows to assign all values at instantiation. 
            Car MiniCar = new Car("Mini", "Blue", 2009);
            Console.WriteLine("This car is a " + MiniCar.color + MiniCar.model + " from " + MiniCar.year);
            //access private field by referencing the id property. 
            MiniCar.Owner = "James";
            MiniCar.Password = "123";
            Console.WriteLine("And it's owned by "+ MiniCar.Owner);
            Console.WriteLine(MiniCar.Password);
        }
    }
}