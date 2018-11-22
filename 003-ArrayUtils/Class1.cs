using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ArrayUtils
{
    public class ArrayUtils
    {
        public static void PrintArr(int[] arr)
        {
            Console.WriteLine("Prining an Array of size " + arr.Length);
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }

            //arr[0] = -1;
        }

        public static void PrintArr2(params int[] arr)
        {
            Console.WriteLine("Prining an Array of size " + arr.Length);
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }

            //arr[0] = -1;
        }

    }
}
