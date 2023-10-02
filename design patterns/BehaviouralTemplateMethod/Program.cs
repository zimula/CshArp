using BehaviouralTemplateMethod.Printers;

namespace BehaviouralTemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the product booklet
            Console.WriteLine("Printing booklet for products");
            AbstractBookletPrinter productx = new ProductBookletPrinter();
            //invoking template method
            productx.Print();
            Console.WriteLine("===============================================================");
            //the service booklet
            Console.WriteLine("Printing booklet for products");
            AbstractBookletPrinter servicex = new ServiceBookletPrinter();
            servicex.Print();
        }
    }
}