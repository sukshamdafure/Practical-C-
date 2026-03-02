using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Span<int> span = numbers;
        span[0] = 100;  // Modifies original array

        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("Using Span:");
        foreach (var num in span)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nUsing ReadOnlySpan:");
        foreach (var num in readOnlySpan)
        {
            Console.Write(num + " ");
        }
    }
}