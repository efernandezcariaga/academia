using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad
{
    public class GetAllByPlanId : EndpointBaseAsync
    .WithRequest<Guid>
    .WithActionResult<List<EspecialidadResponse>>
    {
        private readonly IEspecialidadService _especialidadService;

        public GetAllByPlanId(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }

        [HttpGet("api/especialidades/by-plan/{planId}")]
        public override async Task<ActionResult<List<EspecialidadResponse>>> HandleAsync(Guid planId, CancellationToken cancellationToken = default)
        {
            var results = await _especialidadService.GetAllByPlanIdAsync(planId, cancellationToken);

            return results.Select(x => x.MapDtoToResponse()).ToList();
        }
    }
}
