using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                X1(0);
                Console.WriteLine("Done");
            }
            #region Exception Handling

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(ex.ToString());
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.GetBaseException().Message);
                //string indent = string.Empty;
                //while (ex != null)
                //{
                //    Console.WriteLine($"{indent}{ex.Message}");
                //    ex = ex.InnerException;
                //    indent += "\t";
                //}
                Console.ResetColor();
                throw;
            }

            #endregion // Exception Handling
            Console.ReadKey();
        }

        private static void X1(int i)
        {
            Console.WriteLine("-> X1");
            X2(i);
            Console.WriteLine("X1 ->");
        }
        private static void X2(int i)
        {
            Console.WriteLine("-> X2");
            try
            {
                X3(i);
            }
            catch (DivideByZeroException ex)
            {
                //throw new ArgumentException("Arg shouldn't be zero"); // always use the inner exception
                throw new ArgumentException("Arg shouldn't be zero", ex);
            }
            Console.WriteLine("X2 ->");
        }
        private static void X3(int i)
        {
            Console.WriteLine("-> X3");
            try
            {
                X4(i);
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Don't divide by zero");
                Console.ResetColor();
                // throw ex; Don't do
                throw;
            }
            finally
            {
                Console.WriteLine("Fold");
                //throw new ArgumentOutOfRangeException("Some other error");   
            }
            //catch (ArgumentNullException ex)
            //{
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            Console.WriteLine("X3 ->");
        }
        private static void X4(int i)
        {
            try
            {
                Console.WriteLine("-> X4");
                X5(i);
            }
            finally
            {
                Console.WriteLine("Been here");
            }
            Console.WriteLine("X4 ->");
        }
        private static void X5(int i)
        {
            Console.WriteLine("-> X5");
            if (Environment.TickCount % 2 == 0)
                throw new ArgumentOutOfRangeException("Ticks");
            if(10 / i == 0)
                Console.WriteLine("OK");
            Console.WriteLine("X5 ->");
        }
    }
}
