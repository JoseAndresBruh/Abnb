using Dominio.Departamentos;      // Para que reconozca IRepositorioDepartamentos
using Infraestructura;            // Para que reconozca AddInfrastructure
using Infraestructura.Data;       // Opcional, dependiendo de tu estructura

var builder = WebApplication.CreateBuilder(args);

// Configura Aspire
builder.AddServiceDefaults();

// Registra tus servicios de infraestructura
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapDefaultEndpoints();

// Tu endpoint de prueba
app.MapGet("/departamentos", async (IRepositorioDepartamentos repo) =>
{
    var departamentos = await repo.GetAllAsync();
    return Results.Ok(departamentos);
});

app.Run();