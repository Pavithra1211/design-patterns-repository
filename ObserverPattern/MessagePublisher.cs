using System;
using System.Collections.Generic;


namespace ObserverPattern
{
    public class MessagePublisher : ISubject
    {

        
        private List<IObserver> observers = new List<IObserver>();

        
        public void attach(IObserver o)
        {
            observers.Add(o);
        }

        
        public void detach(IObserver o)
        {
            observers.Remove(o);
        }

       
        public void notifyUpdate(Message m)
        {
            foreach (IObserver o in observers)
            {
                o.update(m);
            }
        }


    }
}
