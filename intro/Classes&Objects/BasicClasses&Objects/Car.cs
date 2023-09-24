using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses_Objects
{
    class Car
    {
        //public string color = "red";
        //public int maxSpeed = 200;
        //leaving fields blank and adding on instantiation
        public string? model;
        public string? color;
        public int maxSpeed;
        public void fullThrottle()//must be public. 
        {
            Console.WriteLine("This car is going as fast as it can!");
        }
         
       
    }
}
/*
 A simple car class with 2 field and a void method. 
- internal: only accessible from this name space.
- void: returns no value, also no parameters passed.
- ?: nullable. */
