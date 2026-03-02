var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/call", async () =>
{
    var client = new HttpClient();
    return await client.GetStringAsync("https://localhost:5002/data");
});

app.Run();