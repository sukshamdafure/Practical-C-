using System;

class Program
{
    static void Main()
    {
        int totalDays;

        Console.Write("Enter number of days: ");
        totalDays = Convert.ToInt32(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int months = remainingDays / 30;
        int days = remainingDays % 30;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + days);
    }
}