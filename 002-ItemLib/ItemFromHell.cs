using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ItemLib
{
    public class ItemFromHell
    {
        public void print()
        {
            Console.WriteLine("Before call");
            printPrivate();
        }

        private void printPrivate()
        {
            Console.WriteLine("Hell Private");
        }

        internal void printInternal()
        {
            Console.WriteLine("Hell internal");
        }
    }
}
