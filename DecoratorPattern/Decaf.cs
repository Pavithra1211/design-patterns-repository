using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Decaf : Beverage
    {
        override
        public Double Cost()
        {
            Double cost = 1.0;
            return cost;
        }

    }
}
