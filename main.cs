using System;

abstract class Shape
{
    public abstract double CalculateArea();

    public abstract string GetShapeName();
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override string GetShapeName()
    {
        return "Rectangle";
    }
}

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle { Length = 10, Width = 5 },
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetShapeName()} Area: {shape.CalculateArea():F2}");
        }
    }
}
