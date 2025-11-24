

using System.ComponentModel.DataAnnotations;

public class Monitor : Usuario
{

    public bool Activo { get; set; } = true;
    public ICollection<Actividad> Actividades { get; set; } = new List<Actividad>();

    public Monitor() { }

    public Monitor(string nombre, string apellidos, string email, string telefono, bool activo, ICollection<Actividad> actividades)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Telefono = telefono;
        Activo = activo;
        Actividades = actividades;
    }
}