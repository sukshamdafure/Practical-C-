using System;

class Program
{
    static void Display(string name = "Guest")
    {
        Console.WriteLine("Welcome " + name);
    }

    static void Main()
    {
        Display();
        Display("Suksham");
    }
}