using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class NoFly : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Decoys can not fly");
        }
    }
}
