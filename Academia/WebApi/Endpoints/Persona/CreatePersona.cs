using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Persona;

namespace WebApi.Endpoints.Persona
{
    public class CreatePersona : EndpointBaseAsync
        .WithRequest<CreateDto>
        .WithActionResult<Guid>
    {
        private readonly IPersonaService _personaService;
        public CreatePersona(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpPost("api/personas")]
        public async override Task<ActionResult<Guid>> HandleAsync(CreateDto request, CancellationToken cancellationToken = default)
        {
            var personaCreated = await _personaService.CreatePersonaAsync(request, cancellationToken);

            return personaCreated?.Id;
        }
    }
}
