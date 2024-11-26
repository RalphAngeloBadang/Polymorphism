Pair Activity: Refactor Code to Apply Object-Oriented Programming (Abstraction, Inheritance, Encapsulation, and Polymorphism)

Objectives:
•	Understand the benefits of polymorphism.
•	Write scalable and maintainable code.
•	Apply object-oriented principles.

Initial Code

using System;

class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculateArea()
    {
        return Length * Width;
    }
}

class Circle
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle { Length = 10, Width = 5 };
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

        Circle circle = new Circle { Radius = 7 };
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
    }
}

Additional Requirement:
•	Refactor the Main method to use polymorphism, making it adaptable for new shapes.
•	Add a Triangle to the system.

class Program
{
    static void Main()
    {
        // Using polymorphism
        Shape[] shapes = new Shape[]
        {
            new Rectangle { Length = 10, Width = 5 },
            new Circle { Radius = 7 }
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine("Area: " + shape.CalculateArea());
        }
    }
}
