using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PubSub_Delegate
{
    public class Pub
    {
        private int _counter;
        public event Action<string, DateTimeOffset> Subscribers;
        private readonly Timer _tmr; // GC friendly

        public Pub()
        {
            _tmr = new Timer(OnTime, null,
                                TimeSpan.FromSeconds(2),
                                TimeSpan.FromSeconds(1));
        }

        private void OnTime(object state)
        {
            // Not thread safe
            _counter++;
            //NotifyDelegate subscribers = Subscribers;
            Action<string, DateTimeOffset> subscribers = Subscribers;
            if (subscribers == null)
                return;
            subscribers($"Message number {_counter}", DateTimeOffset.UtcNow);
            //foreach (NotifyDelegate sub in subscribers.GetInvocationList())
            //{
            //    sub($"Message number {_counter}", DateTimeOffset.UtcNow);
            //}
        }


        /*public void Register(NotifyDelegate sub)
        {
            //_subscribers += sub; //.Add(sub);
            Subscribers += sub;
        }*/

        //public void Unregister(NotifyDelegate sub)
        //{
        //    _subscribers -= sub; //.Remove(sub);
        //}
    }
}
