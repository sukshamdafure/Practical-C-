using System;

class Program
{
    static void Calculate(int a, int b, out int sum, ref int product)
    {
        sum = a + b;
        product = a * b;
    }

    static void Main()
    {
        int x = 10, y = 5;
        int sum;
        int product = 0;

        Calculate(x, y, out sum, ref product);

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Product = " + product);
    }
}