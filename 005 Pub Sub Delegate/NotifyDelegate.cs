using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub_Delegate
{
    public delegate void NotifyDelegate(string message, DateTimeOffset stamp);
}
