// Command
record CreateProduct(string Name);

// Handler
app.MapPost("/products", (CreateProduct cmd) =>
{
    return $"Product Created: {cmd.Name}";
});