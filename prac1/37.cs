using System;

class Program
{
    static void Main()
    {
        double number, power, result;

        Console.Write("Enter number: ");
        number = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter power: ");
        power = Convert.ToDouble(Console.ReadLine());

        result = Math.Pow(number, power);

        Console.WriteLine("Result = " + result);
    }
}