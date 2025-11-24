
public class Reserva
    {
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public DateTime FechaReserva { get; set; }
    public Actividad Actividad { get; set; }
    public EstadoReserva EstadoReserva { get; set; }
    public int? Posicion { get; set; }

    public Reserva() { }

    public Reserva(Cliente cliente, DateTime fechaReserva, Actividad actividad, EstadoReserva estadoReserva, int? posicion)
    {
        Cliente = cliente;
        FechaReserva = fechaReserva;
        Actividad = actividad;
        EstadoReserva = estadoReserva;
        Posicion = posicion;
    }
}