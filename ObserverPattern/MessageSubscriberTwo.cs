using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class MessageSubscriberTwo : IObserver
    {

        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());
        }
    }
}
