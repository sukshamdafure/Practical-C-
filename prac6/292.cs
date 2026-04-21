using System;
using System.IO;

class WriteCSV
{
    static void Main()
    {
        string filePath = "data.csv";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write header
            writer.WriteLine("Name,Age,City");

            // Write data
            writer.WriteLine("John,25,Mumbai");
            writer.WriteLine("Alice,30,Pune");
            writer.WriteLine("Bob,22,Delhi");
        }

        Console.WriteLine("CSV file written successfully!");
    }
}