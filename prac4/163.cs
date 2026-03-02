using Microsoft.Extensions.DependencyInjection;

interface IMessageService
{
    void Send();
}

class EmailService : IMessageService
{
    public void Send() => Console.WriteLine("Email Sent");
}

class Program
{
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddTransient<IMessageService, EmailService>();
        var provider = services.BuildServiceProvider();

        var service = provider.GetService<IMessageService>();
        service.Send();
    }
}