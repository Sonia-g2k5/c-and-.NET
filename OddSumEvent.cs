using System;

delegate void OddDelegate();

class Program
{
    static event OddDelegate OddEvent;

    static void ShowMessage()
    {
        Console.WriteLine("The sum is an odd number!");
    }

    static void Add(int a, int b)
    {
        int sum = a + b;

        Console.WriteLine("Sum = " + sum);

        if (sum % 2 != 0)
        {
            OddEvent?.Invoke();
        }
    }

    static void Main()
    {
        OddEvent += ShowMessage;

        Add(10, 15);
    }
}
