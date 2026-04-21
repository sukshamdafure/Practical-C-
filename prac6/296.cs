using System;
using System.IO;

class CountLines
{
    static void Main()
    {
        string filePath;

        Console.Write("Enter file path: ");
        filePath = Console.ReadLine();

        try
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Number of lines = " + lines.Length);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
