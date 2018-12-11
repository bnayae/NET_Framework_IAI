using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Anonymous_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            bool disable = true;
            Exec(delegate (int x, DateTimeOffset d) { return x > 1 && d < DateTimeOffset.Now; });
            Exec((x, d) => x > 1 && d < DateTimeOffset.Now);
            Exec((x, d) => x > 1);
            Exec((x, d) => !disable && x > 1);
            Exec(Callback);

            Holder h = new Holder(disable);
            Exec(h.Callback);

            Console.ReadKey();
        }


        private static bool Callback(int x, DateTimeOffset dt)
        {
            return true;
        }

        private static int _counter;
        private static void Exec(Func<int, DateTimeOffset, bool> f)
        {
            bool result = f(_counter++, DateTimeOffset.UtcNow);
            Console.WriteLine(result);
        }

        private class Holder
        {
            private bool _disable;
            public Holder(bool disable)
            {
                _disable = disable;
            }
            public bool Callback(int x, DateTimeOffset dt)
            {

                return _disable;
            }

        }
    }
}
