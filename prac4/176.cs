var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var products = Enumerable.Range(1, 50)
    .Select(i => new { Id = i, Name = "Product" + i });

app.MapGet("/products", (int page = 1, int size = 5) =>
{
    return products.Skip((page - 1) * size).Take(size);
});

app.Run();