using System;

class Student
{
    int rollno;
    string name;
    int m1, m2, m3;

    public Student(int r, string n, int a, int b, int c)
    {
        rollno = r;
        name = n;
        m1 = a;
        m2 = b;
        m3 = c;
    }

    public void Display()
    {
        int total = m1 + m2 + m3;
        int lowest = Math.Min(m1, Math.Min(m2, m3));

        double average = (total - lowest) / 2.0;

        Console.WriteLine("Roll Number: " + rollno);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Average of Best Two Marks: " + average);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(101, "Arun", 80, 90, 70);
        s.Display();
    }
}
