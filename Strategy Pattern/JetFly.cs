using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class JetFly : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("This is flying in rocket speed");
        }
    }
}
