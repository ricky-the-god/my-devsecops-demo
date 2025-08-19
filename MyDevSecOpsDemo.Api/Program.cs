var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { status = "ok", service = "my-devsecops-demo" }));
app.MapGet("/add/{a:int}/{b:int}", (int a, int b) => a + b);

app.Run();
public partial class Program { }
