namespace Dominio.Abstracciones;

public class Resultado
{
    protected Resultado(bool exito, Error error)
    {
        if (exito && error != Error.Ninguno || !exito && error == Error.Ninguno)
            throw new InvalidOperationException("Configuración de resultado inválida");
            
        Exito = exito;
        Error = error;
    }

    public bool Exito { get; }
    public bool Falla => !Exito;
    public Error Error { get; }

    public static Resultado Exito() => new(true, Error.Ninguno);
    public static Resultado Fallo(Error error) => new(false, error);
}