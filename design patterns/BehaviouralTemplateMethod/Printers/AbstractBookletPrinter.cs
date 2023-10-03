using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralTemplateMethod.Printers
{
    internal abstract class AbstractBookletPrinter
    {
        //the protected keyword helps. 
        protected internal abstract int PageCount { get; }
        protected internal abstract void PrintFrontCover();
        protected internal abstract void PrintTableOfContents();
        protected internal abstract void PrintBackCover();
        protected internal abstract void PrintPage(int PageNumber);
        protected internal abstract void PrintIndex();

        //The template method:
        public void Print()
        {
            PrintFrontCover();
            PrintTableOfContents();
            PrintBackCover();
            PrintIndex();
            for (int i = 0; i <= PageCount; i++)
            {
                PrintPage(i);
            }
        }
        
    }
}
