using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Exception_Handling
{
    class Simple
    {
        static void Main2(string[] args)
        {
            
            int dividor = 100;
            int denominator = 0; //from user
            bool errorOccured = false;
            try
            {
                Console.WriteLine("-----");
                Console.WriteLine(dividor / denominator);
                Console.WriteLine("-----");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("A divide by zero occured");
                Console.WriteLine(ex.StackTrace);
            }
            catch(NullReferenceException ex2)
            {

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write(e.StackTrace);
                errorOccured = true;
            }

            Console.WriteLine("Trying to connect to db");
            try
            {
                ConnectToDb(83, "127.0.0.1");
                ConnectToDb(79, "127.0.0.1");
                ConnectToDb(80, "127.0.0.1");
                ConnectToDb(81, "127.0.0.1");
                ConnectToDb(83, "127.0.0.1");
            }
            catch(DatabaseException dbException)
            {
                Console.WriteLine(dbException.Message + " on port " + dbException.Port);
                Console.WriteLine(dbException.StackTrace);
            }
            

            

        }

        private static void ConnectToDb(int port, string host)
        {
            Console.WriteLine($"Trying to connect to host {host}");
            Thread.Sleep(2000);
            if(port % 2 ==0)
                throw new DatabaseException(port, host, "Port is already in used");
        }
       
    }

    class Student
    {
        public string Id { get; set; }
    }
}
