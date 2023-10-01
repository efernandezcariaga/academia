using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad
{
    public class GetById : EndpointBaseAsync
    .WithRequest<Guid>
    .WithActionResult<EspecialidadResponse>
    {
        private readonly IEspecialidadService _especialidadService;

        public GetById(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpGet("api/especialidades/{id}")]
        public async override Task<ActionResult<EspecialidadResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _especialidadService.GetByIdAsync(id, cancellationToken);

            if (result == null) return NotFound();

            return result.MapDtoToResponse();
        }
    }
}
