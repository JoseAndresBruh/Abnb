using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infraestructura.Data;
using Infraestructura.Data.Repository;

namespace Infraestructura;

public static class InyeccionDependencias
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database") 
            ?? throw new ArgumentNullException(nameof(configuration), "Connection string not found.");

        services.AddDbContext<ApplicationContext>(options => 
            options.UseNpgsql(connectionString));

        services.AddScoped<IRepositorioDepartamentos, DepartamentoRepository>();
    }
}