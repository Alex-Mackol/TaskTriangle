using System;

using TaskTriangle.View.InterfaceView;

namespace TaskTriangle.View.ClassView
{
   abstract class Display: IDisplay
    {
        public Display()
        {
        }

        public virtual void GetStringForTriangle(out string name, out string side1, out string side2, out string side3)
        {
            throw new NotImplementedException();
        }

        public virtual bool ToContinueAddingTriangles()
        {
            throw new NotImplementedException();
        }

        public virtual void WriteText(string message)
        {
            Console.WriteLine(message);
        }
    }
}
