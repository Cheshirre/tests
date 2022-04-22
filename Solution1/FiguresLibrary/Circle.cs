namespace FiguresLibrary;

public class Circle : Figure
{
    private readonly double _r;

    public Circle( double r )
    {
        _r = r;
    }

    public override double GetSquare()
    {
        if (_r < 0)
            throw new Exception("Not valid radius");
        return Math.PI * Math.Sqrt(_r);
    }
}