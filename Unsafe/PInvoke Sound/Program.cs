using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PInvoke_Sound
{
    class Program
    {
        private static object _o = new object();
        static void Main(string[] args)
        {
            //GCHandle handle = GCHandle.Alloc(_o, GCHandleType.Pinned);
            //handle.Free();
            //Beep();

            //Console.Beep(1000, 1300);
            
            R2D2();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Beep()
        {
            Native.Beep(400, 1000);
            Thread.Sleep(1500);

            Native.MessageBeep(BeepTypes.Asterisk);
            Thread.Sleep(500);
            Native.MessageBeep(BeepTypes.Exclamation);
        }

        private static void R2D2()
        {
            var rnd = new Random();
            for (int i = 100; i < 8000; i += 300)
            {
                Native.Beep(rnd.Next(100, 8000), rnd.Next(300, 700));
            }
        }
    }
}
