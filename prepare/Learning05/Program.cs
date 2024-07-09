using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq1 = new Square("Orange", 5);
        shapes.Add(sq1);
        Rectangle rec1 = new Rectangle("Red", 5.45, 6.43);
        shapes.Add(rec1);
        Circle cir1 = new Circle("Blue", 4.3);
        shapes.Add(cir1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}