using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class MessageSubscriberOne : IObserver
    {
      
        public void update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());
        }
    }
}
