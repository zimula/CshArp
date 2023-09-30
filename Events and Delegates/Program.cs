using Events_and_Delegates.Email_Classes;
using Events_and_Delegates.Publish_Classes;

namespace Events_and_Delegates
{

    //declaring delegate delegate
    public delegate void GetResult();
    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects from publish and email classes
            ResultPublishEvent e = new ResultPublishEvent();
            EmailHandler mail = new EmailHandler();


            e.PublishResult += mail.SendEmail;// registering method with event
            e.PublishResultNow();//calling method with delegate call. 
            Console.ReadLine();
        }
    }
}