﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class QuackSilent : IQuackStrategy
    {
        public void DoQuack()
        {
            Console.WriteLine("sh!");
        }
    }
}
