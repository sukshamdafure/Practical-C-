using System;
using System.Threading;

class LoadingSpinner
{
    static void Main()
    {
        char[] spinner = { '|', '/', '-', '\\' };

        Console.Write("Loading ");

        for (int i = 0; i < 20; i++) // controls duration
        {
            foreach (char c in spinner)
            {
                Console.Write(c);
                Thread.Sleep(100);   // delay for animation
                Console.Write("\b"); // move cursor back
            }
        }

        Console.WriteLine("\nDone!");
    }
}