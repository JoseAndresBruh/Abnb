namespace Dominio.Abstracciones;

public record Error(string Codigo, string Nombre)
{
    public static readonly Error Ninguno = new(string.Empty, string.Empty);
}