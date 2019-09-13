using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {

        Beverage beverage;  // Instance variable of Beverage class

        public Espresso(Beverage b)  // b - beverage passed to the constructor
        {
            this.beverage = b;
        }

        public Espresso()  // b - beverage passed to the constructor
        {
            
        }

        override
        public Double Cost()
        {
            Double cost = 1.0;
            if (beverage == null)
            {
                return cost;
            }
            else {
                return cost + beverage.Cost();
            }
            
        }

    }
}
