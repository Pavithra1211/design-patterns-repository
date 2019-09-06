using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns;

namespace Client
{
    class ObserverClient
    {

        public static void main(String[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            

            MessagePublisher p = new MessagePublisher();

            p.attach(s1);
            p.attach(s2);

            p.notifyUpdate(new Message("First Message"));   //s1 and s2 will receive the update

            p.detach(s1);
           

            p.notifyUpdate(new Message("Second Message")); //s2 and s3 will receive the update
        }
    }
}
