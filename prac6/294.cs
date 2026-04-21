using System;
using System.IO;

class MoveFile
{
    static void Main()
    {
        string sourcePath, destinationPath;

        Console.Write("Enter source file path: ");
        sourcePath = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        destinationPath = Console.ReadLine();

        try
        {
            File.Move(sourcePath, destinationPath);
            Console.WriteLine("File moved successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}