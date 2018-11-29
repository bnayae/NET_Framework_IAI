using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Inheritance
{
    public class Programmer : Employee
    {
        public Programmer(string idOfProgrammer) :base(idOfProgrammer)
        {
            Console.WriteLine("Im in Programmer c'tor , my Id" + Id);
        }
        public Programmer(string id, int inYear ) : base(id)
        {
            InYear = inYear;
            Console.WriteLine($"Programmer: {Id} , In Year : {InYear}" );
        }

        public override int CalcSalary()
        {
            return base.CalcSalary() * 10;
        }

        public new void Print()
        {
            Console.WriteLine($"Programmer: {Id}. In Year {InYear}");
            //base.Print();
        }

        public int DegreeLength { get; } = 3;
        public int InYear { get; set; }
    }
}
