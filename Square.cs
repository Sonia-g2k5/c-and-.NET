using System;

class Square
{
    double side;

    public Square(double s)
    {
        side = s;
    }

    public double Area()
    {
        return side * side;
    }

    public double Perimeter()
    {
        return 4 * side;
    }
}

class Program
{
    static void Main()
    {
        Square s = new Square(5);

        Console.WriteLine("Area = " + s.Area());
        Console.WriteLine("Perimeter = " + s.Perimeter());
    }
}
