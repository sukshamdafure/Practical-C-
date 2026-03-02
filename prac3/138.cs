using System;

delegate void MyDelegate(string msg);

class Program
{
    static void Main()
    {
        MyDelegate del = delegate (string message)
        {
            Console.WriteLine(message);
        };

        del("Anonymous Method Called");
    }
}
