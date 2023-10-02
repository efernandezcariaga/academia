using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad
{
    public class Update : EndpointBaseAsync
        .WithRequest<EspecialidadUpdateRequest>
        .WithActionResult<BooleanResultResponse>
    {
        private readonly IEspecialidadService _especialidadService;
        public Update(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpPut("api/especialidades")]
        public async override Task<ActionResult<BooleanResultResponse>> HandleAsync(EspecialidadUpdateRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _especialidadService.UpdateEspecialidadAsync(request, cancellationToken);

            return Ok(new BooleanResultResponse { Result = result });
        }
    }
}
