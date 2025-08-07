
using System.Runtime.CompilerServices;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea() //overrides the base class method
    {
        return _length * _width;
    }
}