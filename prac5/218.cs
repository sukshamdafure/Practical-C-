using System;

class NeonNumber
{
    static void Main()
    {
        int number, square, sum = 0, remainder;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        square = number * number;

        while (square > 0)
        {
            remainder = square % 10;  // extract digit
            sum += remainder;
            square /= 10;
        }

        if (sum == number)
            Console.WriteLine("It is a Neon Number");
        else
            Console.WriteLine("It is NOT a Neon Number");
    }
}
