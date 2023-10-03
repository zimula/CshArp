using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associaton
{
    internal class Address
    {
        public int ID {  get; set; }
        public string Name {  get; set; }
        public string City { get; set; }

        public Address(int id, string name, string city)
        {
            this.ID = id;
            this.Name = name;
            this.City = city;
        }

    }
}
