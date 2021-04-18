using System;

using TaskTriangle.Controllers.ClassController;
using TaskTriangle.Models.ClassModel;
using TaskTriangle.View.ClassView;

namespace TaskTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialize Components
            Validator validator = new Validator();
            DisplayTriangles displayTriangles = new DisplayTriangles();
            TriangleFactory triangleFactory = new TriangleFactory();
            TriangleSquareCompare squareCompare = new TriangleSquareCompare();
            #endregion

            TriangleController triangleController = new TriangleController(validator, displayTriangles, triangleFactory, squareCompare);
            triangleController.StartTriangleAnalizing();
            Console.ReadKey();
        }
    }
}
