
using TaskTriangle.Controllers.InterfaceController;

namespace TaskTriangle.Controllers.ClassController
{
    internal class Validator: IValidator
    {
        public Validator()
        {
        }

        public bool TryParsing(string sideInString)
        {
            return double.TryParse(sideInString, out _);
        }

        public bool IsTriangleCreated(double side1, double side2, double side3)
        {
            return ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1));
        }
    }
}
