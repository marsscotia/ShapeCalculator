using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Logic
{
    internal class Square : IShape
    {
        private readonly int width;
        
        public string Name => "square";

        public Square(int width)
        {
            this.width = width;
        }

        public double CalculateArea()
        {
            return width * width;
        }

        public double CalculateCircumference()
        {
            return 4 * width;
        }
    }
}
