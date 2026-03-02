using System;

class Program
{
    static void Display(int n)
    {
        if (n <= 0)
            return;

        Console.WriteLine(n);
        Display(n - 1);
    }

    static void Main()
    {
        Display(5);
    }
}