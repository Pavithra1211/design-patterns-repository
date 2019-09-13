using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Quack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quacking duck");
        }
    }
}
