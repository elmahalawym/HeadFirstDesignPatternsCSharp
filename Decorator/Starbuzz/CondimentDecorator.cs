using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    abstract class CondimentDecorator : Beverage
    {
        protected readonly Beverage _beverage;
        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}
