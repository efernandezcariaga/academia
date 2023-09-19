using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace WebApi.Endpoints;

public class GetAll : EndpointBaseAsync
    .WithoutRequest
    .WithActionResult<List<Guid>>
{
    private readonly IPersonaService _personaService;

    public GetAll(IPersonaService personaService)
    {
        _personaService = personaService;
    }

    [HttpGet("api/personas")]
    public async override Task<ActionResult<List<Guid>>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var list = await _personaService.GetAllAsync(cancellationToken);
        return list.Select(x => x.Id).ToList();
    }
}
