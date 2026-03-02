using System;
using System.IO;

class Program
{
    static string path = "data.txt";

    static void Main()
    {
        File.WriteAllText(path, "Hello CRUD");
        string content = File.ReadAllText(path);
        Console.WriteLine(content);
    }
}