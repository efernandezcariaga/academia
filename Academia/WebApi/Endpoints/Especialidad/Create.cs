using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad
{
    public class Create : EndpointBaseAsync
        .WithRequest<EspecialidadCreateRequest>
        .WithActionResult<EspecialidadResponse>
    {
        private readonly IEspecialidadService _especialidadService;
        public Create(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpPost("api/especialidades")]
        public async override Task<ActionResult<EspecialidadResponse>> HandleAsync(EspecialidadCreateRequest request, CancellationToken cancellationToken = default)
        {
            var especialidadCreated = await _especialidadService.CreateEspecialidadAsync(request, cancellationToken);

            return especialidadCreated.MapDtoToResponse();
        }
    }
}
