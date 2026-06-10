using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("blue", 5);
        shapes.Add(s1);
        Square s2 = new Square("red", 7);
        shapes.Add(s2);
        Circle c1 = new Circle("black", 5);
        shapes.Add(c1);
        Rectangle r1 = new Rectangle("blue", 5, 3);
        shapes.Add(r1);
        Rectangle r2 = new Rectangle("blue", 6, 4);
        shapes.Add(r2);
        Rectangle r3 = new Rectangle("blue", 8, 3);
        shapes.Add(r3);


        foreach (Shape shape in shapes)
        {
            string color = shape.Color;
            double area = shape.GetArea();

            Console.WriteLine($"the {color} {shape} has an area of {area}");
        }

    }
}