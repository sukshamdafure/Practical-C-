using System;

static class MathUtility
{
    public static int Square(int x)
    {
        return x * x;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Square = " + MathUtility.Square(5));
    }
}