using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Plan;

public class GetAll : EndpointBaseAsync
    .WithoutRequest
    .WithActionResult<List<PlanResponse>>
{
    private readonly IPlanService _planService;

    public GetAll(IPlanService planService)
    {
        _planService = planService;
    }

    [HttpGet("api/planes")]
    public async override Task<ActionResult<List<PlanResponse>>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var results = await _planService.GetAllAsync(cancellationToken);

        return results.Select(x => x.MapDtoToResponse()).ToList();
    }
}
