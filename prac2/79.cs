using System;

class Program
{
    static void ShowDetails(string name, int age)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        ShowDetails(age: 20, name: "Suksham");
    }
}