using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Animals
{
    public abstract class Animal
    {
        public Animal(ConsoleColor color)
        {
            Color = color;
        }

        /*public virtual int getLegs()
        {
            return 0;
        }*/

        /*public string Voice
        {
            get { return string.Empty; }
        }*/
        //c 5#
        //public string Voice { get; }= string.Empty
        // C# 6
        protected abstract string Voice { get; }
        protected abstract string Name { get; }
        protected abstract int getSpeed();
        //without Abstract
        //protected virtual int Legs => 0;
        protected abstract int Legs { get; }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Legs = {Legs} Voice = {Voice}");
            Console.WriteLine(Name);
            Console.ResetColor();
        }
        

        public void Draw(TimeSpan ts)
        {
            int distance = ts.Hours * getSpeed();
            string nPoint = new string('*', distance);
            Console.WriteLine($"{nPoint} {Voice}");
        }






        

        protected ConsoleColor Color { get; }
    }
}
