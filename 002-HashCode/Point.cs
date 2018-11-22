using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HashCode
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
//        public Studedent st;

        public Point()
        {

        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this)) return true;
            if (obj == null || GetType() != obj.GetType()) return false;
            Point other = (Point)obj;

            return X == other.X  && Y == other.Y;
        }

        public override int GetHashCode()
        {
            int hash = 19;
            hash = (hash * 23) ^ X;
            hash = (hash * 31) ^ Y;
            //in case of Reference type ,use its GetHashCode

            return hash;

        }


    }
}
