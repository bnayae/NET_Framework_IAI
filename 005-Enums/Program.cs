using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c = Color.Red;
            Color outputColor;
            //Init from String
            Color red = (Color)Enum.Parse(typeof(Color), "Red");
            if(Enum.TryParse<Color>("Red", out outputColor))
                Console.WriteLine("Parse was successfull");

            GetValues(Color.Black);

        }

        
        static void GetValues(Color c)
        {
            Array arr = Enum.GetValues(typeof(Color)); 
            foreach(Color color in arr)
            {
                int val = (int)color;
                Console.WriteLine(color + " " + val);
                if(color == c)
                    Console.WriteLine("The best color in the world is " + c);
            }

            Array names = Enum.GetNames(typeof(Color));
            foreach(string n in names)
            {
                Console.WriteLine(n); 
            }
        }
    }
}
