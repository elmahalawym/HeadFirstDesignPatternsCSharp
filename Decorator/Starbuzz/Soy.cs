using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage) { }

        public override string Description => _beverage.Description + ", Soy";

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }
    }
}
