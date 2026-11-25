using System;

class Time
{
    int hours, minutes, seconds;

    public void GetTime()
    {
        Console.Write("Enter hours: ");
        hours = int.Parse(Console.ReadLine());

        Console.Write("Enter minutes: ");
        minutes = int.Parse(Console.ReadLine());

        Console.Write("Enter seconds: ");
        seconds = int.Parse(Console.ReadLine());
    }

    public void Display()
    {
        if (hours < 1 || hours > 12)
            throw new Exception("Invalid Hour");

        if (minutes < 0 || minutes > 59)
            throw new Exception("Invalid Minute");

        if (seconds < 0 || seconds > 59)
            throw new Exception("Invalid Second");

        Console.WriteLine("Time: {0:D2}:{1:D2}:{2:D2}",
            hours, minutes, seconds);
    }
}

class Program
{
    static void Main()
    {
        Time t = new Time();

        try
        {
            t.GetTime();
            t.Display();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
