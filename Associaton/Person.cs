using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associaton
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public Address Address { get; set; } 
        
        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.age = age;
        }
        public void setAdress(Address address)
        {
            Address = address;
        }
    }
}
