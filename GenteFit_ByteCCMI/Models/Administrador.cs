

using System.ComponentModel.DataAnnotations;

public class Administrador : Usuario
{
    public bool Activo { get; set; } = true;

    public Administrador() { }

    public Administrador(string nombre, string apellidos, string email, string telefono, bool activo)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Telefono = telefono;
        Activo = activo;
    }
}