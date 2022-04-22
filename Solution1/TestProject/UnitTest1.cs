using System;
using FiguresLibrary;
using NUnit.Framework;

namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(10, 10)]
    public void TestCircleSquareSuccess( double r, double s )
    {
        Circle circle = new Circle( r );
        Assert.AreEqual(s, Math.Round(circle.GetSquare()) );
    }
    
    [Test]
    [TestCase(10, 11, 12, 51.521)]
    public void TestTriangleSquareSuccess( double a, double b, double c, double s )
    {
        Triangle figure = new Triangle( a, b, c );
        Assert.AreEqual(s, Math.Round(figure.GetSquare(), 3) );
    }
    
    [Test]
    [TestCase(3, 4, 5, 6)]
    public void TestRightTriangleSquareSuccess( double a, double b, double c, double s )
    {
        Triangle figure = new Triangle( a, b, c );
        Assert.AreEqual(s, Math.Round(figure.GetSquare(), 3) );
    }
    
    [Test]
    [TestCase(1, 2, 5, 1)]
    public void TestRightTriangleSquareFail( double a, double b, double c, double s )
    {
        var ex = Assert.Throws<Exception>(() =>
        {
            Triangle figure = new Triangle( a, b, c );
            figure.GetSquare();
        });
        Assert.That(ex?.Message == "Not valid rectangle sides");
    }
    
    [Test]
    [TestCase(1, 1, 1, 1)]
    public void TestCircleSquareFail( double a, double b, double c, double s )
    {
        Circle figure = new Circle( -2 );
        var ex = Assert.Throws<Exception>(()=>figure.GetSquare());
        Assert.That(ex?.Message == "Not valid radius");
    }
}