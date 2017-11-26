using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class DarkRoast : Beverage
    {
        public override string Description => "Dark Roast Coffee";

        public override double Cost()
        {
            return 0.99;
        }
    }
}
