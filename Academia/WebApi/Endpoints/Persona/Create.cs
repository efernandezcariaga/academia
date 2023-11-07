using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Request;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Persona
{
    public class Create : EndpointBaseAsync
        .WithRequest<PersonaCreateRequest>
        .WithActionResult<PersonaResponse>
    {
        private readonly IPersonaService _personaService;
        public Create(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpPost("api/personas")]
        public async override Task<ActionResult<PersonaResponse>> HandleAsync(PersonaCreateRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                var personaCreated = await _personaService.CreatePersonaAsync(request, cancellationToken);

                return personaCreated.MapDtoToResponse();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Message = ex.Message
                });
            }
        }
    }
}
