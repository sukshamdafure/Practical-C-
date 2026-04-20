using System;

class ProductOfDigits
{
    static void Main()
    {
        int number, remainder;
        int product = 1;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            remainder = number % 10;  // get last digit
            product *= remainder;
            number /= 10;
        }

        Console.WriteLine("Product of digits = " + product);
    }
}