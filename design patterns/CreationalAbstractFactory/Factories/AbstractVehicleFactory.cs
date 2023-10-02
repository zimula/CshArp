using CreationalAbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalAbstractFactory.Factories
{
    internal abstract class AbstractVehicleFactory
    {
        public abstract Ibody createBody();
        
    }
}
