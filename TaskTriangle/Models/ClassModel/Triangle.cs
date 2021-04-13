using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TaskTriangle.Models.InterfaceModel;

namespace TaskTriangle.Models.ClassModel
{
    class Triangle : ITriangle
    {
        private string name;
        private double side1;
        private double side2;
        private double side3;

        public string Name
        {
            get => name;

            set
            {
                name = value;
            }
        }

        public double Side1
        {
            get => side1;

            set
            {
                side1 = value;
            }
        }

        public double Side2
        {
            get => side2;

            set
            {
                side2 = value;
            }
        }

        public double Side3
        {
            get => side3;

            set
            {
                side3 = value;
            }
        }

        public Triangle()
        {
            this.name = "Null";
            this.side1 = 0;
            this.side2 = 0;
            this.side3 = 0;
        }

        public double Square
        {
            get => CalculateSquare();
        }

        public Triangle(string name, double side1, double side2, double side3)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        protected double CalculateSquare()
        {
            double poluPerimetr = CalculatePoluPerimeter();
            return Math.Sqrt(poluPerimetr * (poluPerimetr - Side1) * (poluPerimetr - Side2) * (poluPerimetr - Side3));
        }

        protected double CalculatePoluPerimeter()
        {
            return (Side1 + Side2 + Side3) / 2.0;
        }

        public override string ToString()
        {
            return $"[Triangle {Name}]: {Square.ToString(".00 cm")}";
        }
    }
}
