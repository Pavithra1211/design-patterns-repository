using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {

        override
        public Double Cost()
        {
            Double cost = 1.0;
            return cost;
        }
    }
}
