using System;

class OctalToDecimal
{
    static void Main()
    {
        int octal, decimalNum = 0, baseVal = 1, remainder;

        Console.Write("Enter an octal number: ");
        octal = int.Parse(Console.ReadLine());

        while (octal > 0)
        {
            remainder = octal % 10;         // get last digit
            decimalNum += remainder * baseVal;
            baseVal *= 8;
            octal /= 10;
        }

        Console.WriteLine("Decimal number = " + decimalNum);
    }
}