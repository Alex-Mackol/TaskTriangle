using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskTriangle.Controllers.ClassController;

namespace TaskTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleController triangleController = new TriangleController();
            triangleController.StartTriangleAnalizing();
            Console.ReadKey();
        }
    }
}
