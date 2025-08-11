using System;
public abstract class Shape
{
    public string Color { get; set; }
    public Shape(string color)
    {
    Console.WriteLine("Shape created");
    Color = color;
    }

~Shape()
    {
        Console.WriteLine("Shape destroyed");
    }
    public abstract double GetArea();
    public abstract string GetDetails();
    }

    public class Square : Shape
    {
    private double sideLength;
    public Square(string color, double sideLength) : base(color)
    {
        this.sideLength = sideLength;
    }
    public override double GetArea()
    {
        return sideLength * sideLength;
    }

    public override string GetDetails()
    {
        return $"Shape: Square, Side Length: {sideLength}, Area: {GetArea()}";
    }
}

    public class Circle : Shape
{
    private double radius;
    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

        public override string GetDetails()
    {
        return $"Shape: Circle, Radius: {radius}, Area: {Math.Round(GetArea(), 2)}";
    }
}

    class Program
    {
    static void Main(string[] args)
    {

        CreateAndDisplayShapes();

        Console.WriteLine("\nNya! Meow!");

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
    static void CreateAndDisplayShapes()
    {
        Shape square = new Square("Yellow", 10);
        Console.WriteLine($"Color: {square.Color}");
        Console.WriteLine(square.GetDetails());

        Console.WriteLine();

        Shape circle = new Circle("Green", 5);
        Console.WriteLine($"Color: {circle.Color}");
        Console.WriteLine(circle.GetDetails());
    }
}