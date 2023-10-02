using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Persona
{
    public class GetById : EndpointBaseAsync
    .WithRequest<Guid>
    .WithActionResult<PersonaResponse>
    {
        private readonly IPersonaService _personaService;

        public GetById(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet("api/personas/{id}")]
        public async override Task<ActionResult<PersonaResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _personaService.GetByIdAsync(id, cancellationToken);

            if (result == null) return NotFound();

            return result.MapDtoToResponse();
        }
    }
}
