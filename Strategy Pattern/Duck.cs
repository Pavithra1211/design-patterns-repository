using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public abstract class Duck
    {

        public FlyBehaviour fb;

        public QuackBehaviour qb;

        public Duck(){

        }

        public void setFlybehaviour(FlyBehaviour flybe)
        {
            fb = flybe;
        }

        public abstract void display();

        public void performFly()
        {
            fb.fly();
        }

        public void performQuack()
        {
            qb.quack();
        }

        public void performSwim()
        {
            Console.WriteLine("All ducks including decoys can swim");
        }

        
    }
}
