using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Starbuzz
{
    abstract class Beverage
    {
        public virtual string Description => "Unknown Beverage";

        public abstract double Cost();

        public override string ToString()
        {
            return $"{Description} {Cost()}";
        }
    }
}
