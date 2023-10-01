using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Plan
{
    public class Update : EndpointBaseAsync
        .WithRequest<PlanUpdateRequest>
        .WithActionResult<bool>
    {
        private readonly IPlanService _planService;
        public Update(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpPut("api/planes")]
        public async override Task<ActionResult<bool>> HandleAsync(PlanUpdateRequest request, CancellationToken cancellationToken = default)
        {
            return await _planService.UpdatePlanAsync(request, cancellationToken);
        }
    }
}
