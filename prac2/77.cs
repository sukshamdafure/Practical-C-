using System;

class Program
{
    static int AddNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Sum = " + AddNumbers(1, 2, 3, 4, 5));
    }
}