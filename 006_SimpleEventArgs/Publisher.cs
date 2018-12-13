using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006_SimpleEventArgs
{
    public class Publisher
    {
        //option 1+2 protect in code
        public event MyMessageHandler subscribers;
        
        //option 3 : initalize with empty delegate list
        //public event MyMessageHandler subscribers = delegate{ };

        private readonly Timer _tmr;

        public Publisher()
        {
            _tmr = new Timer(OnTime, null,
                                TimeSpan.FromSeconds(2),
                                TimeSpan.FromSeconds(1));
        }

        private void OnTime(object state)
        {
            //option 1 : protect with IF
            /*if(subscribers != null)
                subscribers(this, new MessageEventArgs(DateTime.Now.ToString()));*/
            
            //Option 2 :
            //in c# 6
            subscribers?.Invoke(this, new MessageEventArgs(DateTime.Now.ToString()));

            
        }
    }
}
