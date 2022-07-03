using ShapeCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.UI
{
    internal class SquareInput : IShapeInput
    {
        public IShape GetShape()
        {
            Console.WriteLine("Please enter the width of the square");
            string? width = Console.ReadLine();
            int w;
            while (!int.TryParse(width, out w))
            {
                Console.WriteLine("Please enter a valid width");
                width = Console.ReadLine();
            }
            return new Square(w);
        }
    }
}
