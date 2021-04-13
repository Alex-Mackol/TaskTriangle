using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTriangle.Models.ClassModel
{
    class TriangleSquareCompare : IComparer<Triangle>
    {
        public int Compare(Triangle t1, Triangle t2)
        {
            int resultCompare = 0;
            if (t1.Square > t2.Square)
            {
                resultCompare = -1;
            }
            else resultCompare = t1.Square == t2.Square ? 0 : 1;

            return resultCompare;
        }
    }
}

