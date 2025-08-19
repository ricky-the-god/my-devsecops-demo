using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment()) { app.UseSwagger(); app.UseSwaggerUI(); }

app.MapGet("/", () => Results.Ok(new { status = "ok", service = "my-devsecops-demo" }));
app.MapGet("/add/{a:int}/{b:int}", ([FromRoute]int a, [FromRoute]int b) => a + b);

app.Run();
public partial class Program { }
