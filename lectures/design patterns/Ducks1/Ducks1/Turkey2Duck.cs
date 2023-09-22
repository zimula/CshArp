using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks1
{
    public class T2DAdaptor: Duck
    {
        private Turkey turkey;
        public T2DAdaptor(Turkey turkey)
        {
            this.turkey = turkey;   
            Name = turkey.Name;
        }
        //add methods. 
    }
}
