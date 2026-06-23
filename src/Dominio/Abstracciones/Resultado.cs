namespace Dominio.Abstracciones;

public class Resultado
{
    protected Resultado(bool exito, Error error)
    {
        if (exito && error != Error.Ninguno || !exito && error == Error.Ninguno)
            throw new InvalidOperationException();
        
        IsExito = exito; // Usamos IsExito para la propiedad
        Error = error;
    }

    public bool IsExito { get; } // Propiedad
    public bool IsFalla => !IsExito;
    public Error Error { get; }

    // Métodos de fábrica
    public static Resultado Exito() => new(true, Error.Ninguno);
    public static Resultado Fallo(Error error) => new(false, error);
}