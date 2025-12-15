var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    message = "Hello World from CI/CD Docker Ubuntu v12111213 3"
});

app.Run();