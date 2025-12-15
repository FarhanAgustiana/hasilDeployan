var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    message = "Hello World from CI/CD Docker Ubuntu v121 asd 1123"
});

app.Run();