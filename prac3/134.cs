using System;

delegate void MyDelegate(string message);

class Program
{
    static void ShowMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        MyDelegate del = ShowMessage;
        del("Hello Delegates");
    }
}