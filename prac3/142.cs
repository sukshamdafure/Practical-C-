using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DisplayAsync();
    }

    static async Task DisplayAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Async Method Executed");
    }
}