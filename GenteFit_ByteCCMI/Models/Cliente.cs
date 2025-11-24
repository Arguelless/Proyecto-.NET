

using System.ComponentModel.DataAnnotations;

public class Cliente : Usuario
{

    public bool Activo { get; set; } = true;
    public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public Cliente () { }

    public Cliente(string nombre, string apellidos, string email, string telefono, bool activo, ICollection<Reserva> reservas)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Telefono = telefono;
        Activo = activo;
        Reservas = reservas;
    }
}