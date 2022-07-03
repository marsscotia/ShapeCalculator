// See https://aka.ms/new-console-template for more information
using ShapeCalculator.Logic;
using ShapeCalculator.UI;

Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter the type of shape: square or rectangle");

string? s = Console.ReadLine();
while (s is null || 
    (!s.Equals("square", StringComparison.OrdinalIgnoreCase) && !s.Equals("rectangle", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Please enter 'square' or 'rectangle'");
    s = Console.ReadLine();
}

IShape? shape = null;

switch (s)
{
    case "square":
        shape = new InputClient(new SquareInput()).GetShape();
        break;
    case "rectangle":
        shape = new InputClient(new RectangleInput()).GetShape();
        break;
    default:
        Console.WriteLine("Something went wrong.");
        break;
}

if (shape is null)
{
    Console.WriteLine("Something went wrong and I couldn't access the shape data.");
}
else
{
    Console.WriteLine($"{shape.Name} has area of {shape.CalculateArea()} and circumference of {shape.CalculateCircumference()}");
}
Console.ReadLine();
