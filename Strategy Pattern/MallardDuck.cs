using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            qb = new Quack();
            fb = new JetFly();
        }

       
        public override void display()
        {
            Console.WriteLine(" This is Mallard Duck ");
        }
    }
}
