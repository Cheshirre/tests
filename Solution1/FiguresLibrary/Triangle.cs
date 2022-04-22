namespace FiguresLibrary;

public class Triangle : Figure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    
    public Triangle( double a, double b, double c )
    {
        if (IsRectangleValid(a, b, c))
        {
            _a = a;
            _b = b;
            _c = c;
        }
        else
        {
            throw new Exception("Not valid rectangle sides");
        }
    }
    
    public override double GetSquare()
    {
        if (IsRectangleValid(_a, _b, _c))
        {
            if (Math.Abs(Math.Sqrt(_c) - (Math.Sqrt(_a) + Math.Sqrt(_b))) < 0.01)
                return (_a * _b) / 2;
            
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        throw new Exception("Not valid rectangle sides");
    }

    private bool IsRectangleValid( double a, double b, double c )
    {
        return a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0;
    }
}