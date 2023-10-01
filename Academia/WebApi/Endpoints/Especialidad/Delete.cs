using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace WebApi.Endpoints.Especialidad
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<bool>
    {
        private readonly IEspecialidadService _especialidadService;
        public Delete(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpDelete("api/especialidades")]
        public async override Task<ActionResult<bool>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _especialidadService.DeleteEspecialidadAsync(id, cancellationToken);

            return Ok(true);
        }
    }
}
