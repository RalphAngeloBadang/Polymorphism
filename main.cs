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

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string GetShapeName()
    {
        return "Circle";
    }
}

class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public override string GetShapeName()
    {
        return "Triangle";
    }
}

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle { Length = 10, Width = 5 },
            new Circle { Radius = 7 },
            new Triangle { Base = 6, Height = 4 }
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetShapeName()} Area: {shape.CalculateArea():F2}");
        }
    }
}