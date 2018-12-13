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
            IFilterRule startegy = new SimpleFilter();
            IEnumerable<int> list = Enumerable.Range(10, 200);
            foreach(var result in FilterExtensions.Filter(list, startegy))
                Console.WriteLine(result);

        }
        static void Main2(string[] args)
        {
            IEnumerable<int> lst = Enumerable.Range(100, 200);
            FilterDelgate f = new FilterDelgate(IsEven);
            IEnumerable<int> result = FilterExtensions.Filter(lst, IsEven);

            var filtered2 = result.ToList();

            //WRONG : delegate signature is not the same
            //var filtered3 = FilterExtensions.Filter3(lst, IsStr).ToList();
            
            //var filtered4 = FilterExtensions.Filter3(lst, x=> x%2 ==0);

            var filtered5 = lst.Filter3(x => x % 2 == 0);
            int max = lst.Max();



        }

        public static bool IsEven(int i)
        {
            return i %2 == 0;
        }

        public static bool IsStr(string s)
        {
            return s.Length > 0;
        }
        public static bool IsGreaterThan(int i)
        {
            return i > 150;
        }

        
    }
}
