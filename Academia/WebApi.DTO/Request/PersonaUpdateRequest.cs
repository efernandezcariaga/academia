using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DTO.Request
{
    public class PersonaUpdateRequest : PersonaCreateRequest
    {
        public Guid Id { get; set; }
    }
}
