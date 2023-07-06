namespace Biblioteca;
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Email { get; set; }

    public Persona(string nombre, int edad, string email)
    {
        Validacion.ValidarCadena(nombre, "Nombre incorrecto");
        this.Nombre = nombre;
        Validacion.ValidarRango(edad, "Edad incorrecta");
        this.Edad = edad;
        Validacion.ValidarCadena(email, "Email incorrecto");
        this.Email = email;
    }
}