using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Point3D : IEquatable<Point3D>
    {
        private int _x;
        private readonly int _z; //public int Z { get; }
        public int Y { get; set; }
        
        public Point3D(int x , int y, int z)
        {
            _z = z;
            //_x = x;
            _x = x;
            Y = y;
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public override string ToString()
        {
            return $"x={_x}, y={Y}, z={_z}";
        }

        public bool Equals(Point3D other)
        {
            return _x == other._x && Y == other.Y && _z == other._z;
            //return this == other; //CANT DO
            //return Object.Equals(other, this);
        }

       /* public override bool Equals(object obj)
        {
            if(!(obj is Point3D))
                return false;
            
            Point3D point = (Point3D)obj;
            return Equals(point);
        }*/
    }
}
