namespace BasicClasses_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This app relies on a simple Classs
            //From which simple cars will be created. 
            Car Mini = new Car();
            //fields values assigned after creation.
            Mini.model = "Mini";
            Mini.color = "blue";
            Mini.maxSpeed = 200;
            Car Passat = new Car();
            Car Corvette = new Car();    
            Car Genesis = new Car();

            Console.WriteLine(Mini.color + " " + Mini.model);
            Mini.fullThrottle();//method execution.
            Console.WriteLine("Its maximum speed is " + Mini.maxSpeed);
        }
    }
}