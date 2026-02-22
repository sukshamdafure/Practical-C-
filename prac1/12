using System;

class FibonacciSeries
{
    static void Main()
    {
        int n, first = 0, second = 1, next;

        Console.Write("Enter number of terms: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }

        Console.ReadLine();
    }
}