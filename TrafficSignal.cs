using System;

delegate void TrafficDel();

class TrafficSignal
{
    TrafficDel[] signals;

    public static void Yellow()
    {
        Console.WriteLine("Yellow Light Signal To Get Ready");
    }

    public static void Green()
    {
        Console.WriteLine("Green Light Signal To Go");
    }

    public static void Red()
    {
        Console.WriteLine("Red Light Signal To Stop");
    }

    public void IdentifySignal()
    {
        signals = new TrafficDel[]
        {
            Yellow,
            Green,
            Red
        };
    }

    public void Show()
    {
        foreach (TrafficDel signal in signals)
        {
            signal();
        }
    }
}

class Program
{
    static void Main()
    {
        TrafficSignal t = new TrafficSignal();

        t.IdentifySignal();
        t.Show();
    }
}
