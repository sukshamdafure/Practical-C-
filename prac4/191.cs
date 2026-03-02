builder.Services.AddIdentityServer()
    .AddInMemoryClients(new[]
    {
        new Client
        {
            ClientId = "client",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = { new Secret("secret".Sha256()) },
            AllowedScopes = { "api" }
        }
    })
    .AddInMemoryApiScopes(new[] { new ApiScope("api") })
    .AddDeveloperSigningCredential();

app.UseIdentityServer();