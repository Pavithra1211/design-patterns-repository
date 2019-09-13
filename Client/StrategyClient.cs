using Design_Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performFly();

            mallard.setFlybehaviour(new NoFly());
            mallard.performFly();
            mallard.performQuack();
            mallard.performSwim();


        }
    }
}
