using Dominio.Departamentos;
using Infraestructura.Data;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Data.Repository;

internal sealed class DepartamentoRepository : IRepositorioDepartamentos
{
    private readonly ApplicationContext _context;

    public DepartamentoRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<List<Departamento>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Departamentos.ToListAsync(cancellationToken);
    }

    public async Task<Departamento?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Departamentos.FirstOrDefaultAsync(d => d.Id == id, cancellationToken);
    }
}