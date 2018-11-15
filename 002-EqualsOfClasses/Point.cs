using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_EqualsOfClasses
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if(GetType() != obj.GetType()) return false;
            //if(typeof(this) != typeof (obj)) return false;
            Point other = (Point)obj;

            return X == other.X
                && Y == other.Y
                && Name.Equals(other.Name);


            

        }


    }
}
