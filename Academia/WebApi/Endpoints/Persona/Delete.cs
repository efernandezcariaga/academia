using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Persona
{
    public class Delete : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<BooleanResultResponse>
    {
        private readonly IPersonaService _personaService;
        public Delete(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpDelete("api/personas/{id}")]
        public async override Task<ActionResult<BooleanResultResponse>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _personaService.DeletePersonaAsync(id, cancellationToken);

            return Ok(new BooleanResultResponse { Result = result });
        }
    }
}
