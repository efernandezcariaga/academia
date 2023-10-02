using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Persona
{
    public class Update : EndpointBaseAsync
        .WithRequest<PersonaUpdateRequest>
        .WithActionResult<BooleanResultResponse>
    {
        private readonly IPersonaService _personaService;
        public Update(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpPut("api/personas")]
        public async override Task<ActionResult<BooleanResultResponse>> HandleAsync(PersonaUpdateRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _personaService.UpdatePersonaAsync(request, cancellationToken);

            return Ok(new BooleanResultResponse { Result = result });
        }
    }
}
