using System;

class Program
{
    static void Main()
    {
        // Lambda expression with two parameters
        Func<int, int, int> add = (a, b) => a + b;

        int result = add(10, 20);
        Console.WriteLine("Addition: " + result);

        // Lambda expression with one parameter
        Func<int, int> square = x => x * x;
        Console.WriteLine("Square: " + square(5));

        // Lambda expression with no return value (Action)
        Action<string> greet = name => 
            Console.WriteLine("Hello " + name);

        greet("Suksham");
    }
}