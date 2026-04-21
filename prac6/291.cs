using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        string filePath = "data.csv";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                foreach (string value in values)
                {
                    Console.Write(value + "\t");
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}