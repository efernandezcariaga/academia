using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Plan
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<BooleanResultResponse>
    {
        private readonly IPlanService _planService;
        public Delete(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpDelete("api/planes/{id}")]
        public async override Task<ActionResult<BooleanResultResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _planService.DeletePlanAsync(id, cancellationToken);

            return Ok(new BooleanResultResponse { Result = result });

        }
    }
}
