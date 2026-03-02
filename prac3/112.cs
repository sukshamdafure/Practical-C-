using System;

class Test
{
    public const int x = 10;        // compile-time constant
    public readonly int y;          // runtime constant

    public Test(int value)
    {
        y = value;
    }
}

class Program
{
    static void Main()
    {
        Test t = new Test(20);
        Console.WriteLine("Const x = " + Test.x);
        Console.WriteLine("Readonly y = " + t.y);
    }
}