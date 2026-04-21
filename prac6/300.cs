using System;
using System.Diagnostics;

class SimpleStopwatch
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        Console.WriteLine("Press ENTER to start stopwatch...");
        Console.ReadLine();

        sw.Start();

        Console.WriteLine("Stopwatch started! Press ENTER to stop...");
        Console.ReadLine();

        sw.Stop();

        Console.WriteLine("Elapsed Time:");
        Console.WriteLine("Milliseconds: " + sw.ElapsedMilliseconds);
        Console.WriteLine("Seconds: " + sw.Elapsed.TotalSeconds);
    }
}