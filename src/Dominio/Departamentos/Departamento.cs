using Dominio.Abstracciones;
using Dominio.Compartido;

namespace Dominio.Departamentos;

public sealed class Departamento : Entidad
{
    // Constructor público que garantiza la integridad
    public Departamento(Guid id, Nombre nombre, Descripcion descripcion, Direccion direccion, Dinero precio) 
        : base(id)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Direccion = direccion;
        Precio = precio;
    }

    private Departamento() { }

    // Quitamos 'required' porque el constructor ya garantiza la inicialización
    public Nombre Nombre { get; private set; }
    public Descripcion Descripcion { get; private set; }
    public Direccion Direccion { get; private set; }
    public Dinero Precio { get; private set; }
}