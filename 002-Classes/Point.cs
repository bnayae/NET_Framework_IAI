using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            //if(x > 0 )
            this.x = x;
        }
    }
}
