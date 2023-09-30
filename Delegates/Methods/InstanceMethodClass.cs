using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Delegates.Methods
{
    internal class InstanceMethodClass
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return (a>b) ? (a-b) : (b-a);
        }
    }
}
