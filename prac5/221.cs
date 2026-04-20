using System;

class SumOfSquares
{
    static void Main()
    {
        int number, remainder, sum = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            remainder = number % 10;      // extract digit
            sum += remainder * remainder; // square and add
            number /= 10;
        }

        Console.WriteLine("Sum of squares of digits = " + sum);
    }
}