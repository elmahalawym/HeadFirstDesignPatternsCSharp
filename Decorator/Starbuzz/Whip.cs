using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string Description => _beverage.Description + ", Whip";

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }
    }
}
