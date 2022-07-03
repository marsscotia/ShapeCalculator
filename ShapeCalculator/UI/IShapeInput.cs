using ShapeCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.UI
{
    internal interface IShapeInput
    {
        IShape GetShape();
    }
}
