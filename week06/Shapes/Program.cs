using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        Circle circle = new Circle("Green", 2);

        //Console.WriteLine($"Square: Color={square.GetColor()}, Area={square.GetArea()}");
        //Console.WriteLine($"Rectangle: Color={rectangle.GetColor()}, Area={rectangle.GetArea()}");
        //Console.WriteLine($"Circle: Color={circle.GetColor()}, Area={circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: Color={shape.GetColor()}, Area={shape.GetArea()}");
        }




    }
}