using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006_SimpleEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            p.subscribers += OnMsgArrived;
            Thread.Sleep(4000);
            p.subscribers -= OnMsgArrived;

            Console.ReadLine();
        }

        private static void OnMsgArrived(object sender, EventArgs args)
        {
            MessageEventArgs mea = (MessageEventArgs)args;
            Console.WriteLine("I got " + mea.Msg);
        }
    }
}
