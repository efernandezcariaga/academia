namespace WebApi.DTO.Dto
{
    public class PersonaDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public PlanDto? Plan { get; set; }
        public Guid PlanId { get; set; }
        public string PlanDescripcion { get; set; }
        public Guid EspecialidadId { get; set; }
        public string EspecialidadDescripcion { get; set; }
    }
}
