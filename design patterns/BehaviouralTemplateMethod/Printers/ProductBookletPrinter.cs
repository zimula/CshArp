using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralTemplateMethod.Printers
{
    internal class ProductBookletPrinter: AbstractBookletPrinter
    {
        protected internal override int PageCount
        {
            get
            {
                return 100;
            }
        }
        protected internal override void PrintFrontCover()
        {
            Console.WriteLine("Printing front cover of product booklet");
        }
        protected internal override void PrintTableOfContents()
        {
            Console.WriteLine("Print table of contents of product booklet");
        }
        protected internal override void PrintPage(int PageNumber)
        {
            Console.WriteLine($"Printig page {PageNumber} of {PageCount}");
        }
        protected internal override void PrintIndex()
        {
            Console.WriteLine("Printing index of product booklet");
        }
        protected internal override void PrintBackCover()
        {
            Console.WriteLine("Print back cover of product booklet");
        }
    }
}
