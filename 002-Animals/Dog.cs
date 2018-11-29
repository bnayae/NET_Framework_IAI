using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Animals
{
    public class Dog : Animal
    {
        public static readonly string DogBark = "Hav";
        private const string VISUAL = @"
  //^ ^\\
 (/(_•_)\)
 _/''*''\_
(,,,)^(,,,)   
";

        public Dog(ConsoleColor c):base(c)
        {
        }
        /*public override int getLegs()
        {
            return 0;
        }*/
        protected override int Legs => 4;
        //public override string Voice => DogBark;
        protected override string Voice => "Hav";
        protected override string Name => VISUAL;


        protected override int getSpeed()
        {
            return 8;
        }

    }

    
}
