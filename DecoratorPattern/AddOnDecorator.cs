using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class AddOnDecorator : Beverage
    {
        override
        public abstract Double Cost();
    }
}
