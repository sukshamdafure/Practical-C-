using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 5;

        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));

        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));

        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("a > 5 && b < 10: " + (a > 5 && b < 10));
    }
}