public class Circle : Shape
{
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    private double _radius;
    public override double GetArea()
    {
        return _radius * 3.142;
    }
}