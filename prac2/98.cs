using System;

class Sample
{
    public int Value;
}

class Program
{
    static void Main()
    {
        // Value Type
        int a = 10;
        int b = a;
        b = 20;

        Console.WriteLine("Value Type:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // Reference Type
        Sample obj1 = new Sample();
        obj1.Value = 10;

        Sample obj2 = obj1;
        obj2.Value = 20;

        Console.WriteLine("Reference Type:");
        Console.WriteLine("obj1.Value = " + obj1.Value);
        Console.WriteLine("obj2.Value = " + obj2.Value);
    }
}