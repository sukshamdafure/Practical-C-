using System;

class PalindromeNumber
{
    static void Main()
    {
        int number, original, reverse = 0, remainder;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        original = number;

        while (number != 0)
        {
            remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number /= 10;
        }

        if (original == reverse)
            Console.WriteLine("The number is Palindrome.");
        else
            Console.WriteLine("The number is Not Palindrome.");

        Console.ReadLine();
    }
}