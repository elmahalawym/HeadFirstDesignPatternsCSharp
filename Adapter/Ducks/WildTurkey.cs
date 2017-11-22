﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ducks
{
    class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
