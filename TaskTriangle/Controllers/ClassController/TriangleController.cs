using System;
using System.Collections.Generic;

using TaskTriangle.View.InterfaceView;
using TaskTriangle.Models.InterfaceModel;
using TaskTriangle.Controllers.InterfaceController;

namespace TaskTriangle.Controllers.ClassController
{
    class TriangleController
    {
        IDisplay displayTriangles;
        IValidator validator;
        IFactory factory;
        IComparer<ITriangle> comparer;

        public TriangleController(IValidator validator, IDisplay displayTriangles, IFactory factory, IComparer<ITriangle> comparer)
        {
            this.validator = validator;
            this.displayTriangles = displayTriangles;
            this.factory = factory;
            this.comparer = comparer;
        }

        public void StartTriangleAnalizing()
        {
            List<ITriangle> triangles = new List<ITriangle>();
            string triangleName, triangleSide1, triangleSide2, triangleSide3;

            do
            {
                displayTriangles.GetStringForTriangle(out triangleName, out triangleSide1, out triangleSide2, out triangleSide3);
                if (CheckOnValidationThreeSides(triangleSide1, triangleSide2, triangleSide3) &&
                    Validation(triangleSide1, triangleSide2, triangleSide3))
                {
                    triangles.Add(GetTriangle(triangleName, triangleSide1, triangleSide2, triangleSide3));
                }
                else
                {
                    displayTriangles.WriteText("Problems are appeared! Numbers are not validated");
                }
            } while (displayTriangles.ToContinueAddingTriangles());

            triangles.Sort(comparer);

            foreach (ITriangle triangle in triangles)
            {
               displayTriangles.WriteText(triangle.ToString());
            }
        }

        private ITriangle GetTriangle(string name, string side1, string side2, string side3)
        {
            return factory.CreateFigure(name, double.Parse(side1), double.Parse(side2), double.Parse(side3));
        }

        private bool Validation(params string[] sides)
        {
            if (sides.Length != 3)
            {
                return validator.TryParsing(sides[0]);
            }
            else
            {
                return validator.IsTriangleCreated(double.Parse(sides[0]), double.Parse(sides[1]), double.Parse(sides[2]));
            }
        }

        private bool CheckOnValidationThreeSides(string side1, string side2, string side3)
        {
            return Validation(side1) && Validation(side2) && Validation(side3);
        }
    }
}
