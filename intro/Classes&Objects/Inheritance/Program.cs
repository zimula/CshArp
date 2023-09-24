namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of car class
            Car mycar = new Car();
            //access method from parent class vehicle
            mycar.Honk();
            Console.WriteLine(mycar.brand + " " + mycar.model);
        }
    }
}