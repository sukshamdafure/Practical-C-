using System;

class AgeNotValidException : Exception
{
    public AgeNotValidException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
                throw new AgeNotValidException("Age must be 18 or above.");

            Console.WriteLine("Valid Age");
        }
        catch (AgeNotValidException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
}