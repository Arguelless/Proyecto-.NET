
public class Actividad
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; } 
    public DateTime HoraInicio { get; set; }
    public DateTime HoraFin { get; set; }
    public Monitor Monitor { get; set; }
    public Sala Sala { get; set; }


    public Actividad() { }

    public Actividad(string nombre, string descripcion, DateTime horaInicio, DateTime horaFin, Monitor monitor, Sala sala)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        HoraInicio = horaInicio;
        HoraFin = horaFin;
        Monitor = monitor;
        Sala = sala;
    }
}