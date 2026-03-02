using System;
using System.Text.Json;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student { Name = "Suksham", Age = 20 };

        string json = JsonSerializer.Serialize(s);
        Console.WriteLine("Serialized: " + json);

        Student obj = JsonSerializer.Deserialize<Student>(json);
        Console.WriteLine("Deserialized: " + obj.Name);
    }
}