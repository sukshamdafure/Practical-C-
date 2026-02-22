using System;

class ArmstrongNumber
{
    static void Main()
    {
        int number, original, remainder, result = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        original = number;

        while (number != 0)
        {
            remainder = number % 10;
            result += remainder * remainder * remainder;
            number /= 10;
        }

        if (original == result)
            Console.WriteLine("The number is Armstrong.");
        else
            Console.WriteLine("The number is Not Armstrong.");

        Console.ReadLine();
    }
}