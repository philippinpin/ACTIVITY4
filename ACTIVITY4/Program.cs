var builder = WebApplication.CreateBuilder(args);

// Add controllers to the services
builder.Services.AddControllers();

var app = builder.Build();

// Custom routes
app.MapControllerRoute(
    name: "operations",
    pattern: "Operations/{operation}/{num1}/{num2}",
    defaults: new { controller = "Operations", action = "Index" });

app.MapControllerRoute(
    name: "advancedOperations",
    pattern: "AdvancedOperations/{operation}/{num}/{exponent?}",
    defaults: new { controller = "AdvancedOperations", action = "Index" });

app.MapControllers();
app.Run();
