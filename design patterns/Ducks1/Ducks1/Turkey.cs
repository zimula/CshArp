using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks1
{
    public class Turkey
    {
        public IGobleStrategi gobleLikeaTurkey;
        public string Name { get; set;}
        public Turkey(string id)
        {
            Name = id;
            gobleLikeaTurkey = new Goble();
        }
    }
}
