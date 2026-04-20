using System;
using System.Text.RegularExpressions;

class ValidateURL
{
    static void Main()
    {
        string url;

        Console.Write("Enter URL: ");
        url = Console.ReadLine();

        string pattern = @"^(http|https)://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(/.*)?$";

        if (Regex.IsMatch(url, pattern))
            Console.WriteLine("Valid URL");
        else
            Console.WriteLine("Invalid URL");
    }
}