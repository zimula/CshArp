using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates.Publish_Classes
{
    internal class ResultPublishEvent
    {
        //event PublishResult of delegate type GetResult using event keyword. 
            //GetResult is declared in the name space. 
        public event GetResult PublishResult;

        public void PublishResultNow()
        {
            if(PublishResult != null){
                Console.WriteLine("We are publishing the result now!");
                Console.WriteLine();
                PublishResult();//invoking delegate. 
            }
        }
    }
}
