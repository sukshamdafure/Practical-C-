using System;

class RotateDigits
{
    static void Main()
    {
        int number, lastDigit, remaining, digits = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        int temp = number;

        // Count digits
        while (temp > 0)
        {
            digits++;
            temp /= 10;
        }

        // Get last digit
        lastDigit = number % 10;

        // Remove last digit
        remaining = number / 10;

        // Rotate
        int rotated = lastDigit * (int)Math.Pow(10, digits - 1) + remaining;

        Console.WriteLine("Rotated number = " + rotated);
    }
}