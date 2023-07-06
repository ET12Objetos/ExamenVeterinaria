namespace Biblioteca;
public class Pets
{
    public List<Animal> Pacientes { get; set; }
    public List<Veterinario> Profesionales { get; set; }
    public List<Visita> Visitas { get; set; }

    public Pets()
    {
        this.Pacientes = new List<Animal>();
        this.Profesionales = new List<Veterinario>();
        this.Visitas = new List<Visita>();
    }

    public void CrearVisita(Visita visita) => this.Visitas.Add(visita);

    public void AgregarPaciente(Animal paciente) => this.Pacientes.Add(paciente);

    public void AgregarProfesional(Veterinario profesional) => this.Profesionales.Add(profesional);

    public void ImprimirVisitas(DateOnly fechaConsulta)
    {
        //imprimir listado de visitas filtradas 
        //por fecha en orden creciente por hora
        var resultado = Visitas.Where(x => x.Fecha.Day == fechaConsulta.Day
            && x.Fecha.Month == fechaConsulta.Month
            && x.Fecha.Year == fechaConsulta.Year)
                .OrderBy(x => fechaConsulta);

        Console.WriteLine($"Visita   Paciente    Profesional");
        foreach (var visita in resultado)
        {
            Console.WriteLine($"{visita.Fecha.Hour}:{visita.Fecha.Minute}hs {visita.Paciente.Nombre} {visita.Profesional.Nombre}");
        }
    }
}