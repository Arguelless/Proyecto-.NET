
using System.ComponentModel.DataAnnotations.Schema;

public class ActividadProgramada
{
    public int Id { get; set; }

    public int ActividadTipoId { get; set; }
    public ActividadTipo ActividadTipo { get; set; }

    public DateTime HoraInicio { get; set; }
    public DateTime HoraFin { get; set; }

    public int MonitorId { get; set; }
    public Monitor Monitor { get; set; }

    public int SalaId { get; set; }
    public Sala Sala { get; set; }

    public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    [NotMapped]
    public string NombreCompleto => ActividadTipo?.Nombre ?? "Sin tipo";


    public ActividadProgramada() { }

    public ActividadProgramada(int actividadTipoId, DateTime horaInicio, DateTime horaFin, int monitorId, int salaId, ICollection<Reserva> reservas)
    {
        ActividadTipoId = actividadTipoId;
        HoraInicio = horaInicio;
        HoraFin = horaFin;
        MonitorId = monitorId;
        SalaId = salaId;
        Reservas = reservas;
    }
}