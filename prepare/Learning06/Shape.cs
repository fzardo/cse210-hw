public class Shape
{
    protected string _color;
    protected double _area;

    public Shape(string color)
    {
        _color = color;
    }

    public virtual string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return _area;
    }
}