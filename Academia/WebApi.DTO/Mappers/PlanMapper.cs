using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using WebApi.DTO.Dto;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.DTO.Mappers
{
    public static class PlanMapper
    {
        public static PlanResponse MapDtoToResponse(this PlanDto dto)
        {
            return new PlanResponse()
            {
                Id = dto.Id,
                Descripcion = dto.Descripcion,
                EspecialidadId = dto.EspecialidadId,
                EspecialidadDescripcion = dto.EspecialidadDescripcion,
            };
        }

        public static PlanDto MapDomainToDto(this Plan domain)
        {
            return new PlanDto()
            {
                Id = domain.Id,
                Descripcion = domain.Descripcion,
                EspecialidadId = domain.Especialidad.Id,
                EspecialidadDescripcion = domain.Especialidad.Descripcion,
            };
        }

        public static Plan MapRequestToDomain(this PlanCreateRequest request)
        {
            return new Plan()
            {
                Descripcion = request.Descripcion,
            };
        }
    }
}
