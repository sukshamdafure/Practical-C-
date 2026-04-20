using System;

class SpyNumber
{
    static void Main()
    {
        int number, remainder;
        int sum = 0, product = 1;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            remainder = number % 10;  // extract digit
            sum += remainder;
            product *= remainder;
            number /= 10;
        }

        if (sum == product)
            Console.WriteLine("It is a Spy Number");
        else
            Console.WriteLine("It is NOT a Spy Number");
    }
}