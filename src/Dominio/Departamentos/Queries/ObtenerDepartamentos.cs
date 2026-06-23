using Dominio.Departamentos;

namespace Aplicacion.Departamentos.Queries;

public record ObtenerDepartamentosQuery();

public class ObtenerDepartamentosHandler
{
    private readonly IRepositorioDepartamentos _repositorio;

    public ObtenerDepartamentosHandler(IRepositorioDepartamentos repositorio)
    {
        _repositorio = repositorio;
    }

    public async Task<List<Departamento>> Handle(ObtenerDepartamentosQuery query, CancellationToken cancellationToken)
    {
        return await _repositorio.GetAllAsync(cancellationToken);
    }
}