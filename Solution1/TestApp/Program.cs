// See https://aka.ms/new-console-template for more information

using FiguresLibrary;

//todo: какие округления важны? пока будет без округлений

try
{
    IFigure figure = new Circle(10);
    Console.WriteLine(figure.GetSquare());
}
catch (Exception ex)
{
    Console.WriteLine( ex.Message );
}

try
{
    IFigure figure2 = new Triangle(10, 20, 30);
    Console.WriteLine(figure2.GetSquare());
}
catch (Exception ex)
{
    Console.WriteLine( ex.Message );
}
    
try
{
    IFigure figure3 = new Triangle(3, 4, 5);
    Console.WriteLine(figure3.GetSquare());
}
catch (Exception ex)
{
    Console.WriteLine( ex.Message );
}
