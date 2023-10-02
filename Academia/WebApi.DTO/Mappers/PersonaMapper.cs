using Domain.Entities;
using WebApi.DTO.Dto;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.DTO.Mappers
{
    public static class PersonaMapper
    {
        public static PersonaResponse MapDtoToResponse(this PersonaDto dto)
        {
            return new PersonaResponse() {
                Id =  dto.Id,
                Apellido = dto.Apellido,
                Nombre = dto.Nombre,
                Direccion = dto.Direccion,
                Email = dto.Email,
                Legajo = dto.Legajo,
                Telefono = dto.Telefono,
                FechaNacimiento = dto.FechaNacimiento,
            };
        }

        public static PersonaDto MapDomainToDto(this Persona domain)
        {
            return new PersonaDto()
            {
                Id = domain.Id,
                Apellido = domain.Apellido,
                Nombre = domain.Nombre,
                Direccion = domain.Direccion,
                Email = domain.Email,
                Legajo = domain.Legajo,
                Telefono = domain.Telefono,
                FechaNacimiento = domain.FechaNacimiento,
            };
        }

        public static Persona MapRequestToDomain(this PersonaCreateRequest request)
        {
            return new Persona()
            {
                Apellido = request.Apellido,
                Nombre = request.Nombre,
                Direccion = request.Direccion,
                Email = request.Email,
                Legajo = request.Legajo,
                Telefono = request.Telefono,
                //FechaNacimiento = request.FechaNacimiento,
            };
        }
    }
}
