using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<Foo, int>();
            d.Add(new Foo { Id = 1 }, 1);
            //d.Add(new Foo { Id = 1 }, 1);

            //SampleA();
        }

        private static void SampleA()
        {
            var dic = new Dictionary<string, int>();
            dic.Add("A", 1);
            dic["A"]++;
            //dic.Add("A", 1);
            dic["A"] = 10;
            dic.Remove("A");
            dic["C"] = 9;
            dic.Add("B", 2);
            if (dic.ContainsKey("A"))
            {
                int i = dic["A"];
                dic["A"] = i + 1;
            }
            else
            {
                dic.Add("A", 1);
            }
        }
    }
}
