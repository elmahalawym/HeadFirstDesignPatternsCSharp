using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class HouseBlend : Beverage
    {
        public override string Description => "House Blend Coffee";

        public override double Cost()
        {
            return 0.89;
        }
    }
}
