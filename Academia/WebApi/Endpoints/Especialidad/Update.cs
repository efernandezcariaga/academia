using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad
{
    public class Update : EndpointBaseAsync
        .WithRequest<EspecialidadUpdateRequest>
        .WithActionResult<bool>
    {
        private readonly IEspecialidadService _especialidadService;
        public Update(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpPut("api/especialidades")]
        public async override Task<ActionResult<bool>> HandleAsync(EspecialidadUpdateRequest request, CancellationToken cancellationToken = default)
        {
            return await _especialidadService.UpdateEspecialidadAsync(request, cancellationToken);
        }
    }
}
