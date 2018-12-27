using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_Generic_Collections
{
    class Foo
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Foo;
            if (other == null)
                return false;
            return Id == other.Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
