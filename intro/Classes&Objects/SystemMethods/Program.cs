namespace SystemMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1,1);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(Object.ReferenceEquals(p1,p2));
        }
    }
}