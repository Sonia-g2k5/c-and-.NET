using System;

class Circle
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double Area()
    {
        return 3.14 * radius * radius;
    }

    public double Perimeter()
    {
        return 2 * 3.14 * radius;
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle(5);

        Console.WriteLine("Area = " + c.Area());
        Console.WriteLine("Perimeter = " + c.Perimeter());
    }
}
