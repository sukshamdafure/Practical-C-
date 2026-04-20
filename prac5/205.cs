using System;

class DecimalToOctal
{
    static void Main()
    {
        int number;
        string octal = "";

        Console.Write("Enter a decimal number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            int remainder = number % 8;
            octal = remainder + octal;  // prepend remainder
            number /= 8;
        }

        Console.WriteLine("Octal number = " + octal);
    }
}