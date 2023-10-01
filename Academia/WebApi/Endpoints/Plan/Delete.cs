using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace WebApi.Endpoints.Plan
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<bool>
    {
        private readonly IPlanService _planService;
        public Delete(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpDelete("api/planes")]
        public async override Task<ActionResult<bool>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _planService.DeletePlanAsync(id, cancellationToken);

            return Ok(true);
        }
    }
}
