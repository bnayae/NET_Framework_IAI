using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// see more: http://msdn.microsoft.com/en-us/library/y31yhkeb(VS.80).aspx
//           http://www.c-sharpcorner.com/uploadfile/rajeshvs/pointersincsharp11112005051624am/pointersincsharp.aspx
//           http://msdn.microsoft.com/en-us/library/aa664784(VS.71).aspx

namespace UnSafeSample
{
    class Program
    {
        private static int _state = 30;
        private static int[] _arr = { 1,2,3,4,5};

        static void Main(string[] args)
        {
            int i = Exec1(1);
            Console.WriteLine("i = {0}", i);

            int j;
            unsafe
            {
                j = Exec2(&i); // send i address
            }
            Console.WriteLine("j = {0}", j);

            ByteByByte(j);

            int k;
            unsafe
            {
                fixed (int* p = &_state)
                {
                    k = Exec2(p);
                }
            }
            Console.WriteLine("k = {0}", k);

            unsafe
            {
                fixed (char* p = "Hello")
                    StrManip(p);
            }

            ArrManip();

            Console.ReadKey();
        }

        private unsafe static int Exec1(int x)
        {
            int* px = &x; // take x address
            *px = 2987912;

            Console.WriteLine("Memory address = {0}", (int)px);

            return *px;
        }

        //private unsafe static int Exec2(ref int x)
        //{
        //    int* px = &x;
        //    *px = 30;

        //    return *px;
        //}

        private unsafe static int Exec2(int* px)
        {
            (*px)++;

            return *px;
        }

        private unsafe static void ByteByByte(int x)
        {
            // Convert to byte:
            byte* p = (byte*)&x;

            System.Console.Write("The 4 bytes of the integer:");

            // Display the 4 bytes of the int variable:
            for (int i = 0; i < sizeof(int); ++i)
            {
                System.Console.Write(" {0:X2}", *p);
                // Increment the pointer:
                p++;
            }
            Console.WriteLine();
            Console.WriteLine("The value of the integer: {0}", x);
        }

        private unsafe static void StrManip(char* p)
        {
            for (int i = 0; p[i] != '\0'; ++i)
                Console.WriteLine(p[i]);
        }

        private unsafe static void ArrManip()
        {
            int[,] a = new int[5, 3];
            unsafe
            {
                fixed (int* p = a)
                {
                    for (int i = 0; i < a.Length; ++i)   // treat as linear
                        p[i] = i;
                }
            }
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("[{0},{1}] = {2}, ", i, j, a[i, j]);
                Console.WriteLine();               
            }
        }
    }
}
