using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() =>
        {
            Console.WriteLine("Task Running");
        });

        task.Wait();
    }
}