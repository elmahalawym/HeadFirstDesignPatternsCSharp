using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class Espresso : Beverage
    {

        public override string Description => "Espresso";

        public override double Cost()
        {
            return 1.99;
        }
    }
}
