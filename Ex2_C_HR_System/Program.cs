using EX2_C_HR_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_C_HR_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HR System.");
            int n = 0;
            Console.WriteLine("Please enter # of Divisions");
            //we assume the input is legal
            int.TryParse(Console.ReadLine(), out n); 

            HrSystem hr = new HrSystem(n);
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine($"please enter all names of workers in division {i+1} with : as seperator e.g ronit:avi:yossi:einat");
                string names = Console.ReadLine();
                hr.SetDivisionData(i, names);
            }

            hr.Print();
            Console.ReadLine();
            Console.WriteLine(hr.AllData());
            Console.ReadLine();

            //Bonus : lets build a new HR system from the existing one
            HrSystem hr2 = new HrSystem(hr.AllData());
            Console.WriteLine("Printing a copy of the first HR System !");
            hr2.Print();

            //2 more tests
            Console.WriteLine("A Test with legal input");
            string legal = "#avi:ronen:dori#liat:amos#shani:eden:harel:dana#moshe:ishai:rafi:dikla:dor:amit#";
            HrSystem hr3 = new HrSystem(legal);
            hr3.Print();

            Console.WriteLine("A Test with ilegal input");
            string notLegal = legal.Remove(0, 1); //removing the first #
            HrSystem hr4 = new HrSystem(notLegal);
            hr4.Print(); // should be empty
            Console.ReadLine();
        }
    }
}
