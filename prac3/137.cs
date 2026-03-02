using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Action<string> greet = name => Console.WriteLine("Hello " + name);
        Predicate<int> isEven = n => n % 2 == 0;

        Console.WriteLine("Sum: " + add(5, 3));
        greet("Suksham");
        Console.WriteLine("Is Even: " + isEven(4));
    }
}