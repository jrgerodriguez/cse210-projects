using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 10, 5));
        shapes.Add(new Circle("yellow", 3));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The area of the {color} shape is {area:N2} m");
        }          

    }
}