using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.Behavior.Observer
{
    public class Publisher: IObservable<Magazine>
    {
        List<IObserver<Magazine>> observers { get; set; }
        public Publisher()
        {
            observers = new List<IObserver<Magazine>>();
        }
        public IDisposable Subscribe(IObserver<Magazine> observer)
        {
            observers.Add(observer);
            return null;
        }

        public void RemoveObserver(IObserver<Magazine> observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(Magazine m)
        {
            foreach (IObserver<Magazine> o in observers)
            {
                o.OnNext(m);
                o.OnCompleted();
            }
        }
    }

    
}
