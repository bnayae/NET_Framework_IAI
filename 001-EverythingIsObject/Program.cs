using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_EverythingIsObject
{
    /// <summary>
    /// Class Student -> Empty
    /// </summary>
    class Student { }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 5;
            Console.WriteLine($"i.Equals(j) :{i.Equals(j)}");
            Console.WriteLine($"i == j :{i == j}"); 
            
            //Equals
            string s1 = "hello";
            string s2 = "world";
            Console.WriteLine($"s1 != s2 : {s1 !=s2}");
            Console.WriteLine($"!Equals(s1,s2) : {!Equals(s1,s2)}");
            s2 = null;
            Console.WriteLine("setting o2=null");
            Console.WriteLine($"Equals(null,s2) {Equals(null, s2)}");
            Console.WriteLine("setting o2=hello");
            s2 = "hello";
            Console.WriteLine($"Equals(s,s2) {Equals(s1,s2)}");

            //Refference Equals
            object o1 = new object();
            object o2 = new object();
            Console.WriteLine($"ReferenceEquals(o1, o2) : { ReferenceEquals(o1, o2)}");
            Console.WriteLine($"ReferenceEquals(o1, o1) : { ReferenceEquals(o1, o1)}");
            
            Console.WriteLine($"!ReferenceEquals(o1, null) : { !ReferenceEquals(o1, null)}");

            ReferenceEquals(o1, o2);
            ReferenceEquals(o1, o1);
            ReferenceEquals(o1, null);
            o1 = null;
            ReferenceEquals(o1, null);

            double d = 12;
            string str = "hello World";
            Int32 iDotNet = 12;
            Console.WriteLine($"d == iDotNet {d == iDotNet}");

            Student st = new Student();
            Student st2 = new Student();
            Type studentType = st2.GetType();
            printMetadata(d);
            printMetadata(str);
            printMetadata(iDotNet);
            printMetadata(st);
            printMetadata(st2);
            printMetadata(studentType);

            Console.WriteLine("Equality with Ref Types");
            Console.WriteLine($"ReferenceEquals(st, st2): {ReferenceEquals(st, st2)}");
            Console.WriteLine($"st == st2: {st == st2}");
            Console.WriteLine($"st.Equals(st2): {st.Equals(st2)}");
            Console.WriteLine($"Equals(st2,st): {Equals(st2,st)}");
            

            Console.WriteLine("a small Catch !");
            AreTheSame(i, j);
            object oI = i;
            AreTheSame(oI,oI);

            
            Console.WriteLine("Press Any Key to Continue");
            
            Console.ReadLine();
            
        }

        static void printMetadata(object o)
        {
            Console.WriteLine("===metdata Info==");
            Console.WriteLine($"toString: {o.ToString()}");
            Console.WriteLine($"GetType: {o.GetType()}");
            //Console.WriteLine($"GetType FullName: {o.GetType().FullName}");
            //Console.WriteLine($"GetHashCode: {o.GetHashCode()}");


        }

        static void AreTheSame(object o1,object o2)
        {
            Console.WriteLine($"ReferenceEquals(o1, o2) : {ReferenceEquals(o1, o2)}");
        }
    }
}
