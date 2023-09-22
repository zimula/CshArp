using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace classesNobjects
{

//Simple structure of C#: namespace>class>main 
    //first class in my namespace
    public class Point : Imethods//Base class
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X,Y) = (x, y);//Constructor
        
        //methods inherited from interface. 
        public void something()
        {
            Console.WriteLine("fffff");
        }

        public void multipy()
        {
            Console.WriteLine("ggggggg");
        }

        public void add()
        {
            Console.WriteLine("hhhhhh");
        }
    }

    // a class to generate random points
    public class PointFactory(int numberOfPoints)
    {
        public IEnumerable<Point> CreatePoints()//constructor
            //IEnumerable allow reading (looping) list, arrays etc. 
        {
            var generator = new Random();
            for(int i = 0;i< numberOfPoints; i++)
            {
                yield return new Point(generator.Next(), generator.Next());
            }
        }
    }

//Type parameters: the pair as an example.
        //multiple parameters are declared using angle brackes. 
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second) //constructor
        {
            //this.First = first;
            //this.Second = second;
            //a simpler way. 
            (First, Second) = (first, second);
            
        }
    }

//Base classes: first signs of inheritance and polymorphism. 
    //referencing to a Base class.
    public class Point3D: Point
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z): base(x, y)
        {
            this.Z = z;
        }
    }

//Structs: store data values, can't declare base. Can't no behavior I guess.  
    public struct Pointstruct
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Pointstruct(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

//Interfaces: Contains abstract methods and properties. With empty bodies (provided in classes).
    //*****Used on poínt class and children. Once used on base class, they can be inherited by child classes. 
    interface IPoint
    {
        void add(); 
    }
    interface ImoreMath : IPoint //add() is available to this interface. 
    {
        void multipy();
    }
    interface Imethods: ImoreMath //this one has access to add() and multiply().
    {
        void something();
    }
        //testing it out on a class. 
    

//Enums: used to define a seet of constant values. 
    //vegetable list and seasons as examples. 
    public enum Vegetables
    {
        Potato,
        Carrots, 
        Turnip
    }
    public enum Seasons
    {
        None = 0, 
        Summer = 1,
        Autumn = 2, 
        Winter = 3,
        Spring = 4,
        All = Summer| Autumn| Winter | Spring
    }
//Nullable type: variables that can hold a null value "?"
    //a simple example
    class Test
    {
        int? op = default;
        string? opStr = default;
    }
//Tuples: grouping of multiple data elements in a lightweigh data structure. 
    //It looks like so (Tuple<sting_i,...,string_k>tuple_name = new Tuple<string_i,...,string_k>("string_i",...,"string_k")).
        //can be different data types. 

    internal class Program
    {
        
        static void Main(string[] args)
        {
            //using manual class
            var p1 = new Point(3, 4);

            //using automatic class
            var factory = new PointFactory(20);

            //testing pair
            var pair = new Pair<string, int>("Martin", 3);
            foreach (var point in factory.CreatePoints())
            {
                Console.WriteLine($"({point.X},{point.Y})");
            }

            //testing base/inheritance
            Point3D b = new Point3D(1, 2, 3);
            //an instance of base class can access child class values like so;
            Point a = new Point3D(1,2 ,3);
            //testing struct
            Pointstruct m = new(1,2);
            //testing enums
            var theyear = Seasons.Summer;
            
            Console.WriteLine("{0} {1}", p1.X, p1.Y);
            Console.WriteLine($"{pair.First},{pair.Second}");
            Console.WriteLine(b.Z);
            Console.WriteLine("struct: {0}{1}", m.X, m.Y);
            p1.something();//applying method from interface on class Point. 
            b.multipy();
            Console.WriteLine(theyear);
        }
    }
}