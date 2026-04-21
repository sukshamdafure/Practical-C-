using System;
using System.IO;

class ListFiles
{
    static void Main()
    {
        string folderPath;

        Console.Write("Enter folder path: ");
        folderPath = Console.ReadLine();

        try
        {
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);

                Console.WriteLine("Files in directory:");

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}