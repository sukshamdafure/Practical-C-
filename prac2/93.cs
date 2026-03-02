using System;

class Program
{
    static void Main()
    {
        string name = "Suksham";
        int age = 20;
        double marks = 85.75;

        // Composite Formatting
        Console.WriteLine("Name: {0}, Age: {1}, Marks: {2}", name, age, marks);

        // String Interpolation
        Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks}");

        // Format Method
        string result = string.Format("Name: {0}, Age: {1}", name, age);
        Console.WriteLine(result);
    }
}