using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");

        Console.WriteLine("After Append: " + sb);

        sb.Insert(5, " C#");
        Console.WriteLine("After Insert: " + sb);

        sb.Remove(5, 3);
        Console.WriteLine("After Remove: " + sb);
    }
}