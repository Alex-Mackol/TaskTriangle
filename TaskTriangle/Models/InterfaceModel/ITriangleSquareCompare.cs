using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTriangle.Models.InterfaceModel
{
    interface ITriangleSquareCompare : IComparer<ITriangle>
    {
        int Compare(ITriangle t1, ITriangle t2);
    }
}
