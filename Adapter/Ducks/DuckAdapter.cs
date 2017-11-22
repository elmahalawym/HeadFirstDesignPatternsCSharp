using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ducks
{
    class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;
        private Random _rnd;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
            _rnd = new Random();
        }

        public void Fly()
        {
            if (_rnd.Next(maxValue: 5) == 0)
                _duck.Fly();
        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
