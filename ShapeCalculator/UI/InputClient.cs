using ShapeCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.UI
{
    internal class InputClient
    {
        private readonly IShapeInput shapeInput;

        public InputClient(IShapeInput shapeInput)
        {
            this.shapeInput = shapeInput;
        }

        public IShape GetShape()
        {
            return shapeInput.GetShape();
        }
    }
}
