using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("Int Sum: " + Add(5, 10));
        Console.WriteLine("Double Sum: " + Add(5.5, 4.5));
    }
}