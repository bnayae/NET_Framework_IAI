using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02B_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder($@"{DateTime.Now:yyyy-MM-dd HH:mm}
###   @    @    ***   $    $  &&&
#  #  @@   @   *   *   $  $  &   &
###   @ @  @  *    *    $   &    &
# #   @  @ @  ******    $   &&&&&&
#  #  @   @@  *    *    $   &    &
###   @    @  *    *    $   &    &");

            
            Console.WriteLine(sb.ToString());
            sb.Replace("&", "!");
            sb.Replace("#", "&");
            sb.Replace("@", "#");
            sb.Replace("*", "@");
            sb.Replace("$", "*");
            sb.Replace("!", "$");

            Console.WriteLine(sb.ToString());

            arrayManip("X", "Y", "C", "B");
        }

        private static void arrayManip(params string[] arr)
        {
            //sort
            Array.Sort(arr);
            //print
            Console.WriteLine("");
            foreach(string item in arr)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("");

            StringBuilder sb = new StringBuilder();
            foreach(string item in arr)
            {
                sb.AppendLine(item);
            }
            Console.WriteLine("***another way to print****");
            Console.WriteLine(sb.ToString());

            //Option 3 :
            //string s3 = string.Join("\r\n", arr);
            string s3 = string.Join(Environment.NewLine, arr);
            Console.WriteLine(s3);

            //Back to Array
            string[] arr2 = s3.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);


        }
    }
}
