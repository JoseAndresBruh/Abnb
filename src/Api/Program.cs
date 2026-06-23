using Infraestructura;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Aquí llama al método que creamos en el paso anterior
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapDefaultEndpoints();

// Endpoint de prueba que hace el profesor
app.MapGet("/departamentos", async (IRepositorioDepartamentos repo) =>
{
    var departamentos = await repo.GetAllAsync();
    return Results.Ok(departamentos);
});

app.Run();