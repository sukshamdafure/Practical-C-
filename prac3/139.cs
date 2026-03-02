using System;

static class ExtensionClass
{
    public static int Square(this int num)
    {
        return num * num;
    }
}

class Program
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Square: " + number.Square());
    }
}