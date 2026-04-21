using System;
using System.IO;

class CopyFile
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
            File.Copy(sourcePath, destinationPath, true); // true = overwrite if exists
            Console.WriteLine("File copied successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}