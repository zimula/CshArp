using CreationalAbstractFactory.Factories;
using CreationalAbstractFactory.Interfaces;

namespace CreationalAbstractFactory
{
    internal class Program
    {
        /*
         Abstract factory: creating 2 types of vehicles with unique parts.
            The hierarchy
                - interface
                - method classes
                - abstract factory: pass methods objects via interface as properties. 
                - override them in each concrete vehicles class
                - This can actually work for automated first food.

                The program has 2 more hierarchies. Iglass and Ichassis.
                */
        static void Main(string[] args)
        {
            //choosing object type to build: Car or Van
            Console.WriteLine("What type of vehicle do you have?");
            string? What2Make = Console.ReadLine();

            //Decide which factory to use. 
            AbstractVehicleFactory? factory = null;

            if (What2Make.Equals("Car") )
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            //Create parts. 
            Ibody VehicleBody = factory.createBody();

            Console.WriteLine(VehicleBody.BodyParts);

        }
    }
}