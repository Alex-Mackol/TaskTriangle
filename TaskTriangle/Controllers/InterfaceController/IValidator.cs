
namespace TaskTriangle.Controllers.InterfaceController
{
    interface IValidator
    {
        bool TryParsing(string sideInString);
        bool IsTriangleCreated(double side1, double side2, double side3);
    }
}
