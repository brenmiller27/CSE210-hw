using System;

public class Retangle : Shape

{
    private double _length;
    private double _width;


    public Rectangle(string color, double length, double width): base (color)

    {
        _length = length;
        _width = width;
    }

    public override double GetArea()

    {
        return _length * width;
    }


}