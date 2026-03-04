using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("red", 2);
        shapes.Add(square1);
        Rectangle rectangle1 = new Rectangle("blue", 2, 6);
        shapes.Add(rectangle1);
        Circle circle1 = new Circle("yellow", 2);
        shapes.Add(circle1);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}