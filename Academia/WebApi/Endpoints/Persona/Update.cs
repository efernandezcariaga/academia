using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Request;
using WebApi.DTO.Respone;

namespace WebApi.Endpoints.Persona
{
    public class Update : EndpointBaseAsync
        .WithRequest<PersonaUpdateRequest>
        .WithActionResult<bool>
    {
        private readonly IPersonaService _personaService;
        public Update(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpPut("api/personas")]
        public async override Task<ActionResult<bool>> HandleAsync(PersonaUpdateRequest request, CancellationToken cancellationToken = default)
        {
            return await _personaService.UpdatePersonaAsync(request, cancellationToken);
        }
    }
}
