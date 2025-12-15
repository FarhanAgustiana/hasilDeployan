var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    message = "Hello World from CI/CD Docker Ubuntu v121113"
});

app.Run();