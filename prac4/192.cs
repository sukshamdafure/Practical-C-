app.MapGet("/data", (HttpContext context) =>
{
    var tenant = context.Request.Headers["TenantId"];
    return $"Data for Tenant: {tenant}";
});