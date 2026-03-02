using System;

class Sample
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Sample obj = new Sample();

        for (int i = 0; i < 5; i++)
        {
            obj[i] = i * 10;
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(obj[i]);
        }
    }
}