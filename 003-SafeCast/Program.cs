using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_SafeCast
{
    class Program
    {
        static void Main(string[] args)
        {

            Programmer p = new Programmer();
            //UP Cast
            Employee e1 = p;
            Console.WriteLine(e1.Id);

            //Down Cast
            //1. Will fail
            Employee e = new Employee();
            try
            {
                Programmer p2 = (Programmer)e;
            }
            catch
            {
                Console.WriteLine("The cast is wrong");
            }

            //2. OK but not good practice
            Programmer p3 = new Programmer();
            Employee other = p3;

            Console.WriteLine("-----------");

            Programmer p4 = (Programmer)other;
            p4.Code();

            Console.WriteLine("A Better Casting approach");

            if(other is Programmer)
            {
                Programmer p5 = (Programmer)other;
                p5.Code();
            }

            Programmer p6 = other as Programmer;
            if (p6 != null)
                p6.Code();

            //C# 6.0 
            (other as Programmer)?.Code();


            Console.ReadLine();


            
        }
    }
}
