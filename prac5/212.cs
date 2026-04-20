using System;

class CountEvenOddDigits
{
    static void Main()
    {
        int number, remainder;
        int evenCount = 0, oddCount = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            remainder = number % 10;  // extract digit

            if (remainder % 2 == 0)
                evenCount++;
            else
                oddCount++;

            number /= 10;  // remove last digit
        }

        Console.WriteLine("Even digits count = " + evenCount);
        Console.WriteLine("Odd digits count = " + oddCount);
    }
}