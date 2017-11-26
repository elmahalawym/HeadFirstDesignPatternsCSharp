using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class Decaf : Beverage
    {
        public override string Description => "Decaf Coffee";

        public override double Cost()
        {
            return 1.05;
        }
    }
}
