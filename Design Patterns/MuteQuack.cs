﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class MuteQuack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("<<  Silence  >>");
        }
    }
}
