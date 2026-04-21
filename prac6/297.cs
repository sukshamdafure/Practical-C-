using System;
using System.IO;

class FileSize
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
                FileInfo fileInfo = new FileInfo(filePath);

                long sizeInBytes = fileInfo.Length;
                double sizeInKB = sizeInBytes / 1024.0;
                double sizeInMB = sizeInKB / 1024.0;

                Console.WriteLine("File Size:");
                Console.WriteLine("Bytes = " + sizeInBytes);
                Console.WriteLine("KB = " + sizeInKB);
                Console.WriteLine("MB = " + sizeInMB);
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