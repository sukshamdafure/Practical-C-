using System;

class MajorityElement
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

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count > n / 2)
            {
                Console.WriteLine("Majority element = " + arr[i]);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("No majority element found");
        }
    }
}