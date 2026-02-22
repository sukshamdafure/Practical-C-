using System;

class SumOfDigits
{
    static void Main()
    {
        int number, sum = 0, remainder;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            remainder = number % 10;
            sum += remainder;
            number /= 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
        Console.ReadLine();
    }
}