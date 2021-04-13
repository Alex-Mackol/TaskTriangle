using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskTriangle.View.ClassView;
using TaskTriangle.Models.ClassModel;

namespace TaskTriangle.Controllers.ClassController
{
    class TriangleController
    {
        DisplayTriangles displayTriangles;
        Validator validator;
        DisplayToContinue toContinue;

        public TriangleController()
        {
            displayTriangles = new DisplayTriangles();
            validator = new Validator();
            toContinue = new DisplayToContinue();
        }

        public void StartTriangleAnalizing(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            string triangleName, triangleSide1, triangleSide2, triangleSide3;

            do
            {
                displayTriangles.GetStringForTriangle(out triangleName, out triangleSide1, out triangleSide2, out triangleSide3);
                if (CheckOnValidationThreeSides(validator, triangleSide1, triangleSide2, triangleSide3) &&
                    Validation(validator, triangleSide1, triangleSide2, triangleSide3))
                {
                    triangles.Add(GetTriangle(triangleName, triangleSide1, triangleSide2, triangleSide3));
                }
                else
                {
                    Console.WriteLine("Problems are appeared!");
                }
            } while (toContinue.OnScreen());

            triangles.Sort(new TriangleSquareCompare());

            foreach (Triangle triangle in triangles)
            {
               displayTriangles.WriteText(triangle.ToString());
            }
        }
        private static Triangle GetTriangle(string name, string side1, string side2, string side3)
        {
            return new Triangle(name, double.Parse(side1), double.Parse(side2), double.Parse(side3));
        }

        private static bool Validation(Validator validator, params string[] sides)
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
        private static bool CheckOnValidationThreeSides(Validator validator, string side1, string side2, string side3)
        {
            return Validation(validator, side1) && Validation(validator, side2) && Validation(validator, side3);
        }
    }
}
