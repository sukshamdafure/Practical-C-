using System;

class Program
{
    static void Main()
    {
        var x = 10;           // Type inferred as int
        dynamic y = 20;       // Type decided at runtime

        Console.WriteLine("var x: " + x);

        y = "Hello";          // dynamic allows type change
        Console.WriteLine("dynamic y: " + y);
    }
}