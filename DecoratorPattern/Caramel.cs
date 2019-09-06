using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{

    //Class caramel is depadent on the reference beverage
    class Caramel : Beverage
    {
        Beverage beverage;  // Instance variable of Beverage class

        public Caramel(Beverage b)  // b - beverage passed to the constructor
        {
            this.beverage = b;
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 2.0;   // We are adding 2.0 to the cost of beverage we are passing to the constructor
        }
    }
}
