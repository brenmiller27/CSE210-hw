using System;

public class Circle : shape 

{
    private double _radius;

    public Circle (string color, double radius) : base (color)

    {
        _radius = radius;
    }

    public override double GetArea()

    {
        return math.PI * _radius * _radius;
    }
}