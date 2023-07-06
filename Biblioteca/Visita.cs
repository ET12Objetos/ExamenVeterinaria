namespace Biblioteca;
public class Visita
{
    public DateTime Fecha { get; set; }
    public Animal Paciente { get; set; }
    public Veterinario Profesional { get; set; }

    public Visita(DateTime fecha, Animal paciente, Veterinario profesional)
    {
        this.Fecha = fecha;
        this.Paciente = paciente;
        this.Profesional = profesional;
    }
}