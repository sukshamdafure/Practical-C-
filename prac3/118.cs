using System;

interface IMessageService
{
    void Send();
}

class EmailService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

class Notification
{
    private IMessageService service;

    public Notification(IMessageService service)
    {
        this.service = service;
    }

    public void Notify()
    {
        service.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessageService service = new EmailService();
        Notification n = new Notification(service);
        n.Notify();
    }
}