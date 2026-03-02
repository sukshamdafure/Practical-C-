using Microsoft.Extensions.Caching.Distributed;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});

var app = builder.Build();

app.MapGet("/data", async (IDistributedCache cache) =>
{
    var cachedData = await cache.GetStringAsync("mydata");

    if (cachedData == null)
    {
        cachedData = "Data from Database";
        await cache.SetStringAsync("mydata", cachedData);
    }

    return cachedData;
});

app.Run();