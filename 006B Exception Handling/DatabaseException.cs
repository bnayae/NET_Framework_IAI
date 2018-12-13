using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Exception_Handling
{
    public class DatabaseException  : Exception
    {
        public int Port { get; set; }
        public string Host { get; set; }
        

        public DatabaseException():base() { }
        public DatabaseException(string message) : base(message) { }

        public DatabaseException(int port,string hostname, string message):base(message)
        {
            Port = port;
            Host = hostname;
        }
    }
}
