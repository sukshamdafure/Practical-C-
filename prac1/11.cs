using System;

class FactorialProgram
{
    static void Main()
    {
        int number;
        long factorial = 1;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial = " + factorial);
        Console.ReadLine();
    }
}