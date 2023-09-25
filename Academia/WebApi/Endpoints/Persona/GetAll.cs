using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints;

public class GetAll : EndpointBaseAsync
    .WithoutRequest
    .WithActionResult<List<PersonaResponse>>
{
    private readonly IPersonaService _personaService;

    public GetAll(IPersonaService personaService)
    {
        _personaService = personaService;
    }

    [HttpGet("api/personas")]
    public async override Task<ActionResult<List<PersonaResponse>>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var results = await _personaService.GetAllAsync(cancellationToken);

        return results.Select(x => x.MapDtoToResponse()).ToList();
    }
}
