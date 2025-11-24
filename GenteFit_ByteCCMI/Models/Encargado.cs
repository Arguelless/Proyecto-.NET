

using System.ComponentModel.DataAnnotations;

public class Encargado : Usuario
{
    public bool Activo { get; set; } = true;

    public Encargado() { }

    public Encargado(string nombre, string apellidos, string email, string telefono, bool activo)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Telefono = telefono;
        Activo = activo;
    }
}