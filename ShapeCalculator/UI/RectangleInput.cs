using ShapeCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.UI
{
    internal class RectangleInput : IShapeInput
    {
        public IShape GetShape()
        {
            Console.WriteLine("Please enter the width of the rectangle");
            string? width = Console.ReadLine();
            int w;
            while (!int.TryParse(width, out w))
            {
                Console.WriteLine("Please enter a valid width");
                width = Console.ReadLine();
            }

            Console.WriteLine("Please enter the height of the rectangle");
            string? height = Console.ReadLine();
            int h;
            while (!int.TryParse(height, out h))
            {
                Console.WriteLine("Please enter a valid height");
                height = Console.ReadLine();
            }

            return new Rectangle(w, h);
        }
    }
}
