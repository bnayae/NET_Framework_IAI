using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PubSub_Delegate
{
    public class PubNotRightWay
    {
        private int _counter;
        private readonly List<NotifyDelegate> _subscribers = new List<NotifyDelegate>();
        private readonly Timer _tmr; // GC friendly

        public PubNotRightWay()
        {
            _tmr = new Timer(OnTime, null,
                                TimeSpan.FromSeconds(2),
                                TimeSpan.FromSeconds(1));
        }

        private void OnTime(object state)
        {
            // Not thread safe
            NotifyDelegate[] subs = _subscribers.ToArray();
            _counter++;
            foreach (NotifyDelegate sub in subs)
            {
                sub($"Message number {_counter}", DateTimeOffset.UtcNow);
            }
        }

        public void Register(NotifyDelegate sub)
        {
            _subscribers.Add(sub);
        }

        public void Unregister(NotifyDelegate sub)
        {
            _subscribers.Remove(sub);
        }
    }
}
