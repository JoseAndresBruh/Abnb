using Dominio.Departamentos; // ¡IMPORTANTE: agrega este using!
using Infraestructura.Data;
using Infraestructura.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructura;

public static class InyeccionDependencias
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database") 
            ?? throw new ArgumentNullException(nameof(configuration), "Connection string not found.");

        services.AddDbContext<ApplicationContext>(options => 
            options.UseNpgsql(connectionString));

        // Registramos la interfaz con su implementación
        services.AddScoped<IRepositorioDepartamentos, DepartamentoRepository>();

        return services;
    }
}