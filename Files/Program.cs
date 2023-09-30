namespace Files
{
    using System.IO; //file class
    internal class Program
    {
        static void Main(string[] args)
        {
            ////adding text to file
            //string writeText = "Hello World";//text to write
            //File.WriteAllText("myfirstfile.txt", writeText); //add text to file. 
            ////reading text from file
            //string readText = File.ReadAllText("myfirstfile.txt");

            //Console.WriteLine(readText);

            //exceptions: example with an array
            //int[] myNumbers = {1, 2, 3 };
            ////trying to find index 10
            //Console.WriteLine(myNumbers[10]);

            //putting everything inside try and catch
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                //trying to find index 10
                Console.WriteLine(myNumbers[10]);
            }
            catch(Exception e)//system message. 
            {
                Console.WriteLine(e.Message);
                //it is possible to add your own error message.
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("The try and catch is finished.");
            }
            
        }
    }
}