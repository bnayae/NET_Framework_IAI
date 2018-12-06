using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Strip : /*IDimentions*/ IDimensionPrintable
    {
        public static int MAX_ITEMS = 100;

        protected /*IDimentions*/ IDimensionPrintable[] _items;
        protected int count = 0;
        public int Width { get; set; }
        public int Height { get; set; }

        public Strip(int w, int h)
        {
            Width = w;
            Height = h;
            _items = new /*IDimentions*/ IDimensionPrintable[MAX_ITEMS];

        }
        #region Add/Remove Operations
        public virtual bool tryAdd(IDimensionPrintable dim)
        {
            if (dim.getWidth() > Width)
                return false;
            if (count + 1 >= MAX_ITEMS)
                return false;

            _items[count++] = dim;
            return true;
        }
        
        public void Print()
        {
            for(int i=0; i< count; ++i)
            {
                _items[i].Print();
            }
        }
        #endregion
        #region IDimension Implementations
        public int getWidth()
        {
            return Width;
        }

        public int getHeight()
        {
            return Height;
        }
        #endregion
    }
}
