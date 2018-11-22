using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            if(a == String.Empty)
                Console.WriteLine("empty");
            if(string.IsNullOrEmpty(a))
                Console.WriteLine("Null or empty true");
            string nullStr = null;
            if (string.IsNullOrEmpty(nullStr))
                Console.WriteLine("Null or empty true");
            String white = "           ";
            if (string.IsNullOrWhiteSpace(white))
                Console.WriteLine("Null or empty true");

            string s1 = "avi_is_a_good_boy";
            string s2 = "rooti";
            int comp = s1.CompareTo(s2);

            string c1 = "hello ";
            string c2 = "world";

            string greeting = string.Concat(c1, c2);
            if(greeting.Equals("Hello World",StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("same same");
            }

            char first = greeting.ToLower()[0];

            int value = 3;
            string number = value.ToString();
            if(greeting.StartsWith("hello",StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("good");
            }

            string sStars = new string('*', 4);
            //String builder

        }
    }
}
