using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int age;
        string city;

        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your city:");
        city = Console.ReadLine();

        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);

        Console.ReadLine();
    }
}