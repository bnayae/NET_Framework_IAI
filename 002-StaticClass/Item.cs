using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_StaticClass
{
    public class Item
    {
        private static int count = 0;
        public Item()
        {
            count++;
        }

        public static int Count { get { return count; } }

    }
}
