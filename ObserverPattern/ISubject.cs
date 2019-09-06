using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
   interface ISubject
    {

        void attach(IObserver o);
        void detach(IObserver o);
        void notifyUpdate(Message m);

    }
}
