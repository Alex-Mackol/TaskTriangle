using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskTriangle.Models.InterfaceModel;

namespace TaskTriangle.Models.ClassModel
{
    class TriangleSquareCompare : ITriangleSquareCompare
    {
        public int Compare(ITriangle t1, ITriangle t2)
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

