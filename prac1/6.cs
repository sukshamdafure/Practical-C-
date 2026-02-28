using System;

class PositiveNegative
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("The number is Positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is Negative.");
        }
        else
        {
            Console.WriteLine("The number is Zero.");
        }

        Console.ReadLine();
    }
}