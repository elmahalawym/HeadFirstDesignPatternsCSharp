using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Milk";
    }
}
