﻿using Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class SwimLikeFloat : ISwimStrategy
    {
        public void DoSwim()
        {
            Console.WriteLine("Flyder med strømmen");
        }
    }
}
