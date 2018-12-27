using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Exec();
            GC.Collect(); // DON'T DO
            GC.WaitForPendingFinalizers();
            GC.Collect(); // DON'T DO

            while (true)
            {
                ///
            }
        }

        private static void Exec()
        {
            using (var nw = new NativeWrapper())
            {
                nw.Start();
                for (int i = 0; i < 30; i++)
                {

                }
            } // dispose time

        }
    }
}
