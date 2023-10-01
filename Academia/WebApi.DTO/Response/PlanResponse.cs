using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DTO.Response
{
    public class PlanResponse
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        //public Especialidad Especialidad { get; set; }
    }
}
