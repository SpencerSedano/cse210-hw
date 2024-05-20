using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square(10, "Red");
        Rectangle rectangle = new Rectangle(20, 10, "Blue");
        Circle circle = new Circle(150, "Brown");

        string squareColor = square.GetColor();
        double squareArea = square.GetArea();

        string rectangleColor = rectangle.GetColor();
        double rectangleArea = rectangle.GetArea();

        string circleColor = circle.GetColor();
        double circleArea = circle.GetArea();

        Console.WriteLine($"This is the square color: {squareColor}");
        Console.WriteLine($"This is the square area: {squareArea}");

        Console.WriteLine($"This is the square color: {rectangleColor}");
        Console.WriteLine($"This is the square area: {rectangleArea}");

        Console.WriteLine($"This is the square color: {circleColor}");
        Console.WriteLine($"This is the square area: {circleArea}");

        // Creating a List for my shapes

        Console.WriteLine("------------ CREATING A LIST ------------");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}