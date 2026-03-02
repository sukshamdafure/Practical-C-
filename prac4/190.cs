builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        options.ClientId = "GOOGLE_CLIENT_ID";
        options.ClientSecret = "GOOGLE_CLIENT_SECRET";
    });

app.UseAuthentication();
app.UseAuthorization();