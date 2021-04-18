
using TaskTriangle.Models.InterfaceModel;

namespace TaskTriangle.Controllers.InterfaceController
{
    interface IFactory
    {
        ITriangle CreateFigure(string name, double side1, double side2, double side3);
    }
}
