

using System.ComponentModel.DataAnnotations;

public class Monitor : Usuario
{

    public bool Activo { get; set; } = true;

    public ICollection<ActividadProgramada> Actividades { get; set; }
        = new List<ActividadProgramada>();

    public Monitor() { }

    public Monitor(string nombre, string apellidos, string email, string password, string telefono, bool activo, ICollection<ActividadProgramada> actividades)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Password = password;
        Telefono = telefono;
        Activo = activo;
        Actividades = actividades;
    }
}