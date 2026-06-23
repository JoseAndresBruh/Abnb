using Aplicacion; // Nuevo using
using Dominio.Departamentos;
using Infraestructura;
using Aplicacion.Departamentos.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication(); // Registrar servicios de aplicacion

var app = builder.Build();

app.MapDefaultEndpoints();

// Endpoint que ahora usa el Handler de Aplicacion
app.MapGet("/departamentos", async (ObtenerDepartamentosHandler handler) =>
{
    var departamentos = await handler.Handle(new ObtenerDepartamentosQuery(), default);
    return Results.Ok(departamentos);
});

app.Run();