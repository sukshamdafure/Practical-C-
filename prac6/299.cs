using System;

class SystemInfo
{
    static void Main()
    {
        Console.WriteLine("System Information:\n");

        Console.WriteLine("Machine Name: " + Environment.MachineName);
        Console.WriteLine("User Name: " + Environment.UserName);
        Console.WriteLine("OS Version: " + Environment.OSVersion);
        Console.WriteLine("64-bit OS: " + Environment.Is64BitOperatingSystem);
        Console.WriteLine("Processor Count: " + Environment.ProcessorCount);
        Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
        Console.WriteLine("System Directory: " + Environment.SystemDirectory);
        Console.WriteLine("CLR Version: " + Environment.Version);
        Console.WriteLine("Uptime (ms): " + Environment.TickCount);
    }
}