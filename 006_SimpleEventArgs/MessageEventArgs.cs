using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_SimpleEventArgs
{
    public class MessageEventArgs : EventArgs
    {
        private string _msg;
        public MessageEventArgs(string data)
        {
            _msg = data;
        }

        public string Msg => _msg;

    }
}
