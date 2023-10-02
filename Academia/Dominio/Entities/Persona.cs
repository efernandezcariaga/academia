namespace Domain.Entities;

public class Persona
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public int Legajo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public Plan? Plan { get; set; }
}