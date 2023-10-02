﻿using CreationalAbstractFactory.Interfaces;
using CreationalAbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalAbstractFactory.Factories
{
    internal class CarFactory:AbstractVehicleFactory
    {
        public override Ibody createBody()
        {
            return new CarBody();
        }
    }
}
