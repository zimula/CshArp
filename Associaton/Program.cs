namespace Associaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intantiate objects
            Person m = new Person(1, "Martin", 90);
            Address n = new Address(1, "Vejlevej 45", "Kolding");
            m.setAdress(n);
            Console.WriteLine(m.Name + " " + "lives at " + m.Address.Name);
        }
    }
}