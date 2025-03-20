using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "METODO GET");
app.MapGet("/parametro/{param1}", 
    ([FromRoute] string param1) =>
    {
        return param1 + " " + DateTime.Now;
    });


app.Run();
