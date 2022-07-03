using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Logic
{
    internal class Rectangle : IShape
    {
        private readonly int width;
        private readonly int height;
        public string Name => "rectangle";

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculateCircumference()
        {
            return 2 * (width + height);
        }
    }
}
