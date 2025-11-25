
public class Reserva
    {
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public int ClienteId { get; set; }
    public DateTime FechaReserva { get; set; }
    public int ActividadProgramadaId { get; set; }
    public ActividadProgramada ActividadProgramada { get; set; }
    public EstadoReserva EstadoReserva { get; set; }
    public int? Posicion { get; set; }

    public Reserva() { }

    public Reserva(Cliente cliente, DateTime fechaReserva, ActividadProgramada actividadProgramada, EstadoReserva estadoReserva, int? posicion)
    {
        Cliente = cliente;
        FechaReserva = fechaReserva;
        ActividadProgramada = actividadProgramada;
        EstadoReserva = estadoReserva;
        Posicion = posicion;
    }
}