using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace WebApi.Endpoints.Persona
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<bool>
    {
        private readonly IPersonaService _personaService;
        public Delete(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpDelete("api/personas")]
        public async override Task<ActionResult<bool>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _personaService.DeletePersonaAsync(id, cancellationToken);

            return Ok(true);
        }
    }
}
