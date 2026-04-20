using System;

class BinaryToDecimal
{
    static void Main()
    {
        int binary, decimalNum = 0, baseVal = 1, remainder;

        Console.Write("Enter a binary number: ");
        binary = int.Parse(Console.ReadLine());

        while (binary > 0)
        {
            remainder = binary % 10;       // get last digit
            decimalNum += remainder * baseVal;
            baseVal *= 2;
            binary /= 10;
        }

        Console.WriteLine("Decimal number = " + decimalNum);
    }
}