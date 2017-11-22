﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ducks
{
    class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;

        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
                _turkey.Fly();
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
