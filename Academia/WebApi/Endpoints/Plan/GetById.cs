using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Plan
{
    public class GetById : EndpointBaseAsync
    .WithRequest<Guid>
    .WithActionResult<PlanResponse>
    {
        private readonly IPlanService _planService;

        public GetById(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpGet("api/planes/{id}")]
        public async override Task<ActionResult<PlanResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _planService.GetByIdAsync(id, cancellationToken);

            if (result == null) return NotFound();

            return result.MapDtoToResponse();
        }
    }
}
