using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strip s = new Strip(200, 900);
            HeightStrip s = new HeightStrip(200,900);
            
            s.tryAdd(new Cat());
            s.tryAdd(new Rect(199, 30));
            s.tryAdd(new Rect(299, 30));
            s.tryAdd(new Square(599));
            s.tryAdd(new Square(50));

            s.Print();
        }
    }
}


