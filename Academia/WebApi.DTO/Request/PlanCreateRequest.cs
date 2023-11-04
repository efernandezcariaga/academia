using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DTO.Request
{
    public class PlanCreateRequest
    {
        public string Descripcion { get ; set; }
        public Guid EspecialidadId { get; set; }
    }
}
