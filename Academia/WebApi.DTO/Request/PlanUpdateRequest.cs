using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DTO.Request
{
    public class PlanUpdateRequest : PlanCreateRequest
    {
        public Guid Id { get; set; }
    }
}
