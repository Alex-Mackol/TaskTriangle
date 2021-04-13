using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTriangle.View.ClassView
{
    class DisplayTriangles : Display
    {
        public override void WriteText(string message)
        {
            base.WriteText(message);
        }

        public void GetStringForTriangle(out string name, out string side1, out string side2, out string side3)
        {
            WriteText("Enter the triangle data as example.\n<name>, <side1>, <side2>, <side3>");
            string input_string = Console.ReadLine();
            string[] dataTriangle;
            dataTriangle = input_string.Split(',');

            if (dataTriangle.Length < 4)
            {
                WriteText("Fill all data");
                name = null;
                side1 = null;
                side2 = null;
                side3 = null;
            }
            else
            {
                name = dataTriangle[0];
                side1 = dataTriangle[1];
                side2 = dataTriangle[2];
                side3 = dataTriangle[3];
            }
        }
    }
}
