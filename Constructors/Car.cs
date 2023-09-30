using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        //access modifiers: private/ protected fields and methods
        private string owner = "martin";
        //property to access and modify private owner. 
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public string? Password { get { return Password; }  set { Password = value; } }
            //works like the owner example but with less code. 


        ////the constructor use for assigning values. 
        //public Car()
        //{
        //    //model = "Mini";
        //    //another of writing this
        //    this.model = "Mini";
        //}
        
        //multi parameter constructor used to pass field values. 
        public Car(string model, string color, int year)
        {
            this.model = model; 
            this.color = color; 
            this.year = year;
        }
        
    }
}
