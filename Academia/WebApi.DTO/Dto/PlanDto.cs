using Domain.Entities;

namespace WebApi.DTO.Dto
{
    public class PlanDto
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public EspecialidadDto Especialidad { get; set; }
        public Guid EspecialidadId { get; set; }
        public string EspecialidadDescripcion { get; set; }
    }
}
