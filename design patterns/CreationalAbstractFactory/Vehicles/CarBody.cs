using CreationalAbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalAbstractFactory.Vehicles
{
    internal class CarBody: Ibody
    {
        public virtual string BodyParts
        {//always override interface properties and methods. 
            get
            {
                return "Here are the body parts for a car!";
            }
        }
    }
}
