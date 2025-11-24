

public class Sala
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public Sala(string nombre, int capacidad)
    {
        Nombre = nombre;
        Capacidad = capacidad;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Sala: {Nombre}, Capacidad: {Capacidad} personas.");
    }
}