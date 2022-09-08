using System;


internal class Rectangle
{
    private double side1 = 0;
    private double side2 = 0;

    public Rectangle(double sideA, double sideB)
    {
        this.side1 = sideA;
        this.side2 = sideB;

    }

    private double AreaCalculator()
    {
        return side1 * side2;
    }

    private double PerimeterCalculator()
    {
        return side1 * 2 + side2 * 2;
    }

    public double Area
    {
        get
        {
            return AreaCalculator();
        }
    }

    public double Perimeter
    {
        get
        {
            return PerimeterCalculator();
        }
    }
    
}

internal static class Test {
    private static void Main()
    {
        Console.Write("a = ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        var b = Convert.ToDouble(Console.ReadLine());
        var rec = new Rectangle(a, b);
        Console.WriteLine($"Area = {rec.Area}\nPerimeter = {rec.Perimeter}");

    }
}

