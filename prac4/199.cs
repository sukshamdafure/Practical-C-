app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = 500;
        await context.Response.WriteAsJsonAsync(new
        {
            Message = "Internal Server Error",
            TraceId = context.TraceIdentifier
        });
    });
});