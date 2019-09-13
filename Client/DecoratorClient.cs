using DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class DecoratorClient
    {
        public static void Main(string []args)
        {

            Beverage b = new Espresso();



            Console.WriteLine("Cost of Espresso is $ {0}", b.Cost());

            //b = new Caramel(b);
            //b = new Caramel(b);

            //double bcost = b.Cost();

            //Console.WriteLine("Cost of beverage after addon is $ {0}", bcost);




            //Double espresso

            b = new Espresso(b);
            b = new Caramel(b);
            b = new Caramel(b);

            Console.WriteLine(b.Cost());



        }


    }
}
