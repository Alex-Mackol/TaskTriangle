
namespace TaskTriangle.View.InterfaceView
{
    interface IDisplay
    {
        bool ToContinueAddingTriangles();
        void GetStringForTriangle(out string name, out string side1, out string side2, out string side3);
        void WriteText(string message);
    }
}
