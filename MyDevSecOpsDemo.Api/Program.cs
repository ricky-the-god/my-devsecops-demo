var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Endpoint racine
app.MapGet("/", () => Results.Ok(new { status = "ok", service = "my-devsecops-demo" }));

// Addition
app.MapGet("/add/{a:int}/{b:int}", (int a, int b) => a + b);

// Hello World
app.MapGet("/hello", () => "Hello, DevSecOps!");

app.Run();

public partial class Program { }
