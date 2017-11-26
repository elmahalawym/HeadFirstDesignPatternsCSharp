using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Mocha";
    }
}
