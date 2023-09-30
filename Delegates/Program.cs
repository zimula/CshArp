using System.Data;
using Delegates.Methods;
namespace Delegates
{
    delegate int MathFunc(int a, int b);
    internal class Program
    {
        /*
            A simple app that relies on a delegate to call methods. 
                - delegates work as references to methods. 
         */
        static void Main(string[] args)
        {
            //calling delegate 
            MathFunc mfa = new MathFunc(MethodsClass.Add);

            Console.WriteLine("Delegates in action!");
            Console.WriteLine("Addition result: "+ " " + mfa(4,5));
            mfa = new MathFunc(MethodsClass.Sub);
            Console.WriteLine("Subtraction result:" + " " +  mfa(4,5));
            // as illustrated, a delegate can be used for multiple methods, as long as they have the same signature.
            

            //The same thing can be done with instance methods. Only require an object before usage. 
            Console.WriteLine("Using instance methods");
            InstanceMethodClass mf = new InstanceMethodClass();
            MathFunc fm = mf.add;
            Console.WriteLine("Addition result: " + fm(4,5));
            fm = mf.sub;
            Console.WriteLine("Subtraction result: " + fm(4,5));
        
        }
    }
}