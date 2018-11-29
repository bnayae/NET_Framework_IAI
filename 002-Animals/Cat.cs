using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Animals
{
    public class Cat : Animal
    {
        private const string VISUAL = @"
\`.|\..----...-'`   `-._.-'_.-'`
/  ' `         ,       __.--'
)/' _/     \   `-_,   /
`-'"" `""\_  ,_.-;_.-\_ ',     
    _.-'_./   {_.'   ; /
   {_.-``-'         {_/                                  
";
        public Cat(ConsoleColor c) : base(c)
        {
        }

        protected override int Legs => 4;
        protected override int Speed => 12;
        protected override string Voice => "Miao";
        protected override string Name => VISUAL;
    }
}
