using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };

        int sum = numbers.Aggregate((a, b) => a + b);

        Console.WriteLine("Sum using Aggregate: " + sum);
    }
}