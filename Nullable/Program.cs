using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> v1 = getValue(10);
            Nullable<int> v2 = getValue(9);

            if(v1.HasValue)
                Console.WriteLine("v1 = " + v1.Value);

            //Console.WriteLine("v1 = " + v2.Value);

            //C# 6
            int? v3 = getValueIfExists(10);

            int v4 = getValueIfExists(10) ?? 4;
            //int v5 = getValueIfExists(0) ?? 4;
            //int v5 = getValueIfExists(0); will not compile

            string db = DbAccess() ?? "NA";
            
            //C# 6 avoid null
            Person person = new Person();
            person?.print();
            string result = person?.print() ?? "NA";


            

        }

        static Nullable<int> getValue(int time)
        {
            if (time % 2 == 0)
                return 42;
            return null;
        }

        //C# 6 and above


        static int? getValueIfExists(int time)
        {
            if (time % 2 == 0)
                return 0;
            return null;
        }

        static string DbAccess()
        {
            return null;
        }
    }
}
