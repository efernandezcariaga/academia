using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Plan
{
    public class Update : EndpointBaseAsync
        .WithRequest<PlanUpdateRequest>
        .WithActionResult<BooleanResultResponse>
    {
        private readonly IPlanService _planService;
        public Update(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpPut("api/planes")]
        public async override Task<ActionResult<BooleanResultResponse>> HandleAsync(PlanUpdateRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _planService.UpdatePlanAsync(request, cancellationToken);

            return Ok(new BooleanResultResponse { Result = result });
        }
    }
}
