using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DTO.Request
{
    public class PersonaCreateRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Guid PlanId { get; set; }
        public Guid EspecialidadId { get; set; }
    }
}
