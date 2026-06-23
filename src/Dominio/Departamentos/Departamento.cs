using Dominio.Abstracciones;
using Dominio.Compartido;

namespace Dominio.Departamentos;

public sealed class Departamento : Entidad
{
    public Departamento(Guid id, Nombre nombre, Descripcion descripcion, Direccion direccion, Dinero precio) 
        : base(id)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Direccion = direccion;
        Precio = precio;
    }

    private Departamento() { } // Requerido por EF Core

    public required Nombre Nombre { get; private set; }
    public required Descripcion Descripcion { get; private set; }
    public required Direccion Direccion { get; private set; }
    public required Dinero Precio { get; private set; }
}