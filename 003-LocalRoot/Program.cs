using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_LocalRoot
{
    class Program
    {
        //static Timer timer;//= new Timer(OnTimer, null, 1000, 1000);
        static void Main(string[] args)
        {
            //Timer timer = new Timer(OnTimer, null, 1000, 1000);
            Timer timer = new Timer(OnTimer, null, 1000, 1000);
            Console.ReadLine();
            //KeepTimerAlive(timer);
            //GC.KeepAlive(timer);
            
        }

        private static void OnTimer(object obj)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
            GC.Collect();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void KeepTimerAlive(Timer t)
        {

        }


    }
}
