using System;
using System.IO;

class DeleteFile
{
    static void Main()
    {
        string filePath;

        Console.Write("Enter file path to delete: ");
        filePath = Console.ReadLine();

        try
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully!");
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