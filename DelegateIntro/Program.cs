using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            FilterDelgate f = new FilterDelgate(IsEven);
            IEnumerable<int> result = FilterExtensions.Filter(Enumerable.Range(100, 200), IsEven);
            var lst2 = result.ToList();
            var lst3 = FilterExtensions.Filter3(Enumerable.Range(100, 200), IsGreaterThan).ToList();
        }

        public static bool IsEven(int i)
        {
            return i %2 == 0;
        }

        public static bool IsGreaterThan(int i)
        {
            return i > 150;
        }
    }
}
