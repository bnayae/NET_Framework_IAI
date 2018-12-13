using _006A_ExternalSubscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PubSub_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start {DateTimeOffset.Now:HH:mm:ss}");
            Pub p = new Pub();
            FixSubscriber sub1 = new FixSubscriber();
            ColorSubscriber sub2 = new ColorSubscriber(ConsoleColor.Yellow);
            p.Subscribers += sub1.React;
            p.Subscribers += sub2.Notify;
            p.Subscribers += OnData;

            // p.Subscribers.Invoke(":(", DateTimeOffset.MinValue); // Disable by event
            //p.Register(sub1.React);
            //p.Register(sub2.Notify);
            //p.Register(OnData);

            Thread.Sleep(TimeSpan.FromSeconds(4.5));
            p.Subscribers -= sub1.React;
            ColorSubscriber sub3 = new ColorSubscriber(ConsoleColor.Green);
            p.Subscribers += sub3.Notify;
            Thread.Sleep(TimeSpan.FromSeconds(5));
            p.Subscribers -= sub2.Notify;
            //p.Unregister(sub3.Notify);

            Console.ReadKey();
            GC.KeepAlive(p);
        }

        static void Main2_WithIncorrectPublisher(string[] args)
        {
            Console.WriteLine($"Start {DateTimeOffset.Now:HH:mm:ss}");
            PubNotRightWay publisher = new PubNotRightWay();

            FixSubscriber sub1 = new FixSubscriber();
            ColorSubscriber sub2 = new ColorSubscriber(ConsoleColor.Yellow);
            MyExternalSubscriber external = new MyExternalSubscriber();

            publisher.Register(sub1.React);
            publisher.Register(sub2.Notify);

            //Task 1 : Add your own Subscriber 
            publisher.Register(OnData);
            publisher.Register(external.OnMessageArrived);

            //Task 2 
            // Wait 4 seconds and 
            Thread.Sleep(4000);
            publisher.Unregister(external.OnMessageArrived);
            //remove the external

            Console.ReadKey();
            GC.KeepAlive(publisher);
        }
        private static void OnData(string m, DateTimeOffset t)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            DateTimeOffset localTime = t.ToLocalTime();
            Console.WriteLine($"{localTime:HH:mm:ss}: {m}");
            Console.ResetColor();
        }


    }
}
