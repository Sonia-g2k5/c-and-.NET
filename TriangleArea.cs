using System;

class Program
{
    static void Area(in double b, in double h, out double area)
    {
        area = 0.5 * b * h;
    }

    static void Main()
    {
        double b = 10, h = 5, result;

        Area(in b, in h, out result);

        Console.WriteLine("Area of Triangle = " + result);
    }
}
