using System;

namespace DecoratorPattern
{
    public abstract class Beverage
    {

        public void getDescription()
        {
            Console.WriteLine("This is beverage abstract class");
        }

        public abstract Double Cost();
    }
}
