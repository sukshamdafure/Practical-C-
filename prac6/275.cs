using System;
using System.Collections.Generic;

class FrequencyUsingDictionary
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of array: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (freq.ContainsKey(arr[i]))
            {
                freq[arr[i]]++;
            }
            else
            {
                freq[arr[i]] = 1;
            }
        }

        Console.WriteLine("Element frequencies:");

        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " occurs " + item.Value + " times");
        }
    }
}