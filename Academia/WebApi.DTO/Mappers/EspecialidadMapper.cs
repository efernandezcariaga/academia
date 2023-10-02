using Domain.Entities;
using WebApi.DTO.Dto;
using WebApi.DTO.Response;
using WebApi.DTO.Request;
using System.Runtime.CompilerServices;

namespace WebApi.DTO.Mappers
{
    public static class EspecialidadMapper
    {
        public static EspecialidadResponse MapDtoToResponse(this EspecialidadDto dto)
        {
            return new EspecialidadResponse()
            {
                Id = dto.Id,
                Descripcion = dto.Descripcion,
            };
        }

        public static EspecialidadDto MapDomainToDto(this Especialidad domain)
        {
            return new EspecialidadDto()
            {
                Id = domain.Id,
                Descripcion = domain.Descripcion,
            };
        }

        public static Especialidad MapRequestToDomain(this EspecialidadCreateRequest request)
        {
            return new Especialidad()
            {
                Descripcion = request.Descripcion,
            };
        }
    }
}
