namespace Dominio.Departamentos;

public interface IRepositorioDepartamentos
{
    Task<Departamento?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Departamento>> GetAllAsync(CancellationToken cancellationToken = default);
}