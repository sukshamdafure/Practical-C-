using System;

class DecimalToBinary
{
    static void Main()
    {
        int number;
        string binary = "";

        Console.Write("Enter a decimal number: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            int remainder = number % 2;
            binary = remainder + binary;  // prepend remainder
            number /= 2;
        }

        Console.WriteLine("Binary number = " + binary);
    }
}