namespace Biblioteca;
public class Veterinario
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public DateOnly Graduacion { get; set; }

    public Veterinario(string nombre, int edad, DateOnly graduacion)
    {
        Validacion.ValidarCadena(nombre, "Nombre incorrecto");
        this.Nombre = nombre;
        Validacion.ValidarRango(edad, "Edad incorrecta");
        this.Edad = edad;
        this.Graduacion = graduacion;
    }
}