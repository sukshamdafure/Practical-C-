using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type type = typeof(string);

        Console.WriteLine("Methods of String class:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}