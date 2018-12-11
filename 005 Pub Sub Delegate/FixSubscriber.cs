using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub_Delegate
{
    public class FixSubscriber 
    {
        public void React(string message, DateTimeOffset stamp)
        {
            DateTimeOffset localTime = stamp.ToLocalTime();
            Console.WriteLine($"{localTime:HH:mm:ss}: {message}");
        }
    }
}
