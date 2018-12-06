using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class HeightStrip : Strip
    {
        public HeightStrip(int w, int h):base(w,h)
        {
        }
        
        #region Add/Remove Operations
        public override bool tryAdd(IDimensionPrintable dim)
        {
            if (dim.getWidth() > Width)
                return false;
            if (count + 1 >= MAX_ITEMS)
                return false;
            int childrenHeight = 0;
            for(int i =0; i < count; ++i)
            {
                childrenHeight += _items[i].getHeight();
            }

            if (dim.getHeight() + childrenHeight > getHeight())
                return false;

            _items[count++] = dim;
            return true;
        }
        #endregion
    }
}
