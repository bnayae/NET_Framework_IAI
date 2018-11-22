using _003_ArrayUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Arrays
{
    class Program
    {

        static void Main3(string[] args)
        {
            Console.WriteLine("Welcome to HR System.");
            int n = 0;
            
            while(true)
            {
                Console.WriteLine("Please enter # of Divisions");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
            }

            HrSystem hr = new HrSystem(n);
            hr.InitHR();
            hr.Print();

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;

            for(int i=0;i< 4; ++i)
            {
                arr[i] = i + 1;
            }

            int[] arr2 = { 1, 2, 3, 4 };
            int[] arr3 = new int[6] {6,5, 4, 3, 2, 1 };

            int l = arr.Length;
            Array.Sort(arr);
            /*for(int i = 0; i < l; ++i)
            {
                Console.WriteLine(arr[i]);
            }

            foreach(int element in arr3)
            {
                Console.WriteLine(element);
            }*/

            ArrayUtils.PrintArr(arr2);
            ArrayUtils.PrintArr(arr2);
            ArrayUtils.PrintArr(arr3);
            ArrayUtils.PrintArr2(arr3);
            ArrayUtils.PrintArr2(1,2,3,4,5,6,7);

            int m = arr.Max();
            
            int indexOfMax = Array.IndexOf(arr,m);
            /*
            int[] arrDynamic;
            int x = 30;
            arrDynamic = new int[x];
            */
        }

        
    }
}






