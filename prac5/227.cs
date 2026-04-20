using System;

class LargestDigit
{
    static void Main()
    {
        int number, remainder;
        int maxDigit = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            remainder = number % 10;  // extract digit

            if (remainder > maxDigit)
                maxDigit = remainder;

            number /= 10;  // remove last digit
        }

        Console.WriteLine("Largest digit = " + maxDigit);
    }
}