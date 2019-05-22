using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Observer
{
    public class Subscriber : IObserver<Magazine>
    {
        private List<Magazine> Magazines { get; set; }
        private Publisher Publisher { get; set; }
        public Subscriber(Publisher pub, Magazine mag)
        {
            Publisher = pub;
            
            Magazines = new List<Magazine>();
            Magazines.Add(mag.Clone());
        }
        public void OnCompleted()
        {
            Console.Write("done");
        }

        public void OnError(Exception error)
        {
            Console.Write("Error");
        }

        public void OnNext(Magazine value)
        {
            Magazines.Add(value.Clone());
        }
    }
}
