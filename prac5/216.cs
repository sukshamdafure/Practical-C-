using System;

class RandomPassword
{
    static void Main()
    {
        int length;
        Console.Write("Enter password length: ");
        length = int.Parse(Console.ReadLine());

        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
        string password = "";
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rand.Next(chars.Length);
            password += chars[index];
        }

        Console.WriteLine("Generated Password: " + password);
    }
}