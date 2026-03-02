using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "apple", "bat", "ball", "cat", "car" };

        var groups = words.GroupBy(w => w[0]);

        foreach (var group in groups)
        {
            Console.WriteLine("Group: " + group.Key);
            foreach (var word in group)
            {
                Console.WriteLine(word);
            }
        }
    }
}