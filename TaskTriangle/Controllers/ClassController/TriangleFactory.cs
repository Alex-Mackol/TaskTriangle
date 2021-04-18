using TaskTriangle.Models.ClassModel;
using TaskTriangle.Models.InterfaceModel;
using TaskTriangle.Controllers.InterfaceController;

namespace TaskTriangle.Controllers.ClassController
{
    class TriangleFactory: IFactory
    {
        public ITriangle CreateFigure(string name, double side1, double side2, double side3)
        {
           return new Triangle(name, side1, side2, side3);
        }
    }
}
