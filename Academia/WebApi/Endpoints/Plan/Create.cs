using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Plan
{
    public class Create : EndpointBaseAsync
        .WithRequest<PlanCreateRequest>
        .WithActionResult<PlanResponse>
    {
        private readonly IPlanService _planService;
        public Create(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpPost("api/planes")]
        public async override Task<ActionResult<PlanResponse>> HandleAsync(PlanCreateRequest request, CancellationToken cancellationToken = default)
        {
            var planCreated = await _planService.CreatePlanAsync(request, cancellationToken);

            return planCreated.MapDtoToResponse();
        }
    }
}
