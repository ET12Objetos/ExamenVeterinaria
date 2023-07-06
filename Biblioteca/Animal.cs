namespace Biblioteca;

public class Animal
{
    public string Nombre { get; set; }
    public DateOnly Nacimiento { get; set; }
    public Persona Dueño { get; set; }

    public Animal(string nombre, DateOnly nacimiento, Persona dueño)
    {
        Validacion.ValidarCadena(nombre, "Nombre incorrecto");
        this.Nombre = nombre;
        this.Nacimiento = nacimiento;
        this.Dueño = dueño;
    }
}
