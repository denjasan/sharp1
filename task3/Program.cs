using System;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;


Point a = new(1, 1);
Point b = new(1, 0);
Point c = new(1, 1);
Point d = new(0, 1);
Figure square = new("ABCD", a, b, c, d);
Console.WriteLine($"Периметр {square.Name}: {square.PerimeterCalculator()}");

internal class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X
    {
        get
        {
            return this.x;
        }
    }

    public double Y
    {
        get
        {
            return this.y;
        }
    }

}


internal class Figure
{
    private Point[] Points;
    public string Name { private set; get;}

    public Figure(string name, Point a, Point b, Point c)
    {
        Name = name;
        Points = new[] { a, b, c };
    }
    public Figure(string name, Point a, Point b, Point c, Point d)
    {
        Name = name;
        Points = new[] { a, b, c, d };
    }
    public Figure(string name, Point a, Point b, Point c, Point d, Point e)
    {
        Name = name;
        Points = new[] { a, b, c, d, e };
    }

    private static double LengthSide(Point a, Point b)
    {
        return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
    }

    public double PerimeterCalculator()
    {
        double result = 0;
        for (var i = 0; i < Points.Length - 1; i++)
        {
            result += LengthSide(Points[i], Points[i + 1]);
        }

        result += LengthSide(Points[0], Points[^1]);
        
        return result;
    }
}

