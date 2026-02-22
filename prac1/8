using System;

class CompoundInterest
{
    static void Main()
    {
        double principal, rate, time, CI, amount;

        Console.Write("Enter Principal Amount: ");
        principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = double.Parse(Console.ReadLine());

        amount = principal * Math.Pow((1 + rate / 100), time);
        CI = amount - principal;

        Console.WriteLine("Compound Interest = " + CI);
        Console.ReadLine();
    }
}