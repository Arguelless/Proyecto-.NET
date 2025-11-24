

using System.ComponentModel.DataAnnotations;

public class Recepcionista : Usuario
{
    public bool Activo { get; set; } = true;

    public Recepcionista() { }

    public Recepcionista(string nombre, string apellidos, string email, string telefono, bool activo)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Telefono = telefono;
        Activo = activo;
    }
}