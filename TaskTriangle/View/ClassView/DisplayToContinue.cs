using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskTriangle.View.InterfaceView;

namespace TaskTriangle.View.ClassView
{
    class DisplayToContinue : Display, IDisplay
    {
        string toContinue;
        public override void WriteText(string message)
        {
            base.WriteText(message);
        }
        public bool OnScreen()
        {
            WriteText("Do you want to input more envelopes ? (y / yes)");
            toContinue = Console.ReadLine();
            return (toContinue.ToLower().Equals("y")||
                  toContinue.ToLower().Equals("yes"));
        }
    }
}
