using System;

class RotateByN
{
    static void Main()
    {
        int number, n;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        Console.Write("Enter number of rotations: ");
        n = int.Parse(Console.ReadLine());

        int digits = number.ToString().Length;
        n = n % digits;  // handle large rotations

        for (int i = 0; i < n; i++)
        {
            int last = number % 10;
            number = (last * (int)Math.Pow(10, digits - 1)) + (number / 10);
        }

        Console.WriteLine("Rotated number = " + number);
    }
}