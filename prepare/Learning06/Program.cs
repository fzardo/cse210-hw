using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 2));
        shapes.Add(new Rectangle("blue", 2, 3));
        shapes.Add(new Circle("yellow", 2));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            Console.WriteLine(color);

            double area = shape.GetArea();
            Console.WriteLine(area);
        }
    }
}