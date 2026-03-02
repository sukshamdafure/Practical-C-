using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);
        set.Add(2); // duplicate ignored

        foreach (int item in set)
        {
            Console.WriteLine(item);
        }
    }
}