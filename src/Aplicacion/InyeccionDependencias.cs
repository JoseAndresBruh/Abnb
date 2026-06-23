using Microsoft.Extensions.DependencyInjection;

namespace Aplicacion;

public static class InyeccionDependencias
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Registro de los casos de uso
        services.AddScoped<Departamentos.Queries.ObtenerDepartamentosHandler>();
        
        return services;
    }
}