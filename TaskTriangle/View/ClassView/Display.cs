using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTriangle.View.ClassView
{
   abstract class Display
    {
        public Display()
        {
        }

        public virtual void WriteText(string message)
        {
            Console.WriteLine(message);
        }
    }
}
