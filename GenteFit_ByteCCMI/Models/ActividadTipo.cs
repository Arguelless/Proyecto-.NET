
public class ActividadTipo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int DuracionMinutos { get; set; }
    public ICollection<ActividadProgramada> ActividadesProgramadas { get; set; }
    = new List<ActividadProgramada>();

    public ActividadTipo() { }

    public ActividadTipo(string nombre, string descripcion, int duracionMinutos, ICollection<ActividadProgramada> actividadProgramadas)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        DuracionMinutos = duracionMinutos;
        ActividadesProgramadas = actividadProgramadas;
    }
}