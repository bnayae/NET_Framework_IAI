using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Cars
{
    public static class CarDefs
    {
        public static readonly string BLUE = "Blue";
        public static readonly string RED = "Red";
        public static readonly string GRAY = "Gray";
        public static readonly string DEFAULT_COLOR = GRAY;
        public static readonly string[] Colors = { BLUE, RED, GRAY };
        public static readonly int MaxAllowedPaintings ;

        public const double PI = 3.14;


        static CarDefs()
        {
            //read from config
            MaxAllowedPaintings = 3;
        }
    }
}
