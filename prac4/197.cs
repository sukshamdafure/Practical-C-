app.MapPost("/register", (User user) =>
{
    if (string.IsNullOrWhiteSpace(user.Email))
        return Results.BadRequest("Invalid Email");

    return Results.Ok();
});

record User(string Email);