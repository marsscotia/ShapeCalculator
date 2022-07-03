using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Logic
{
    internal interface IShape
    {
        string Name { get; }
        double CalculateArea();
        double CalculateCircumference();
    }
}
