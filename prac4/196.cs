builder.Services.AddResponseCaching();

app.UseResponseCaching();

app.MapGet("/fast", () => "Cached Response")
   .WithMetadata(new ResponseCacheAttribute { Duration = 60 });