using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Comparer : IComparer<Rectangle>
    {
        public int Compare(Rectangle x, Rectangle y)
        {
            if (x.GetS() == y.GetS())
                return 1;
            else
                return -1;
        }
    }
}
