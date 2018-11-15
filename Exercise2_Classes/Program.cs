using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("AVi_MESHULAM", "add");
            p1.phone = "0977345345";

            Person p2 = new Person("AVi", "add2",1985,12,12);

            Person p3 = p2.LongerName(p1);
            //p3 = Person.LongerName(p1, p2);
            if(p1 == p3)
            {
                Console.WriteLine("YES !");
            }
            else
            {
                Console.WriteLine(":=<>");
            }


            //Another Person
            Person other = new Person("AVi", "add2", 1985, 12, 12);



            if(other.Equals(p2))
               Console.WriteLine("they are the same");
            else
                Console.WriteLine("they are NOT the same");


            other.Password = "123";
            other.IDNumber = "123456789";
            other.IDNumber = "123";
            //other.setIdNumber("123","v1");
            Console.WriteLine(other.IDNumber);


            //Constants c = new Constants();
            //Constants.ChangeUsers(6);
            Constants.MaxUsers = 6;
            Console.WriteLine(Constants.PI);

        }
    }
}
