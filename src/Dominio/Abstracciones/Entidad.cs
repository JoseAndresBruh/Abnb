namespace Dominio.Abstracciones;

public abstract class Entidad
{
    protected Entidad(Guid id) => Id = id;
    protected Entidad() { } // Constructor protegido para EF Core
    public Guid Id { get; init; }
}