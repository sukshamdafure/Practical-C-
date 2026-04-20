using System;

class SmallestDigit
{
    static void Main()
    {
        int number, remainder;
        int minDigit = 9;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        // Handle case when number is 0
        if (number == 0)
        {
            Console.WriteLine("Smallest digit = 0");
            return;
        }

        while (number > 0)
        {
            remainder = number % 10;  // extract digit

            if (remainder < minDigit)
                minDigit = remainder;

            number /= 10;  // remove last digit
        }

        Console.WriteLine("Smallest digit = " + minDigit);
    }
}