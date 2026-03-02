using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();

app.MapHub<ChatHub>("/chat");

app.Run();

public class ChatHub : Hub
{
    public async Task Send(string message)
    {
        await Clients.All.SendAsync("Receive", message);
    }
}