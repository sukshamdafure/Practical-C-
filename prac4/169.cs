builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://demo.identityserver.io/";
        options.Audience = "api";
    });

app.UseAuthentication();
app.UseAuthorization();