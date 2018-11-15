using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise2_Classes
{
    public static class Constants
    {
        static Constants()
        {
            Console.WriteLine("Connecting to DB");
            Thread.Sleep(2000);
            connectionString = "sql:myConnection:3365";
        }

        public static readonly double PI = 3.14;
        public static int MaxUsers = 4;
        private static string connectionString;


        public static void ChangeUsers(int x)
        {
            MaxUsers = x;
        }
    }
}
