using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<BooleanResultResponse>
    {
        private readonly IEspecialidadService _especialidadService;
        public Delete(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpDelete("api/especialidades/{id}")]
        public async override Task<ActionResult<BooleanResultResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _especialidadService.DeleteEspecialidadAsync(id, cancellationToken);

            return Ok(new BooleanResultResponse { Result = result });
        }
    }
}
