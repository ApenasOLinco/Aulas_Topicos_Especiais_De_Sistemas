using API_Biblioteca.App.Controller;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapGet("/api/livros", LivrosController.GetAllLivros);


app.Run();
