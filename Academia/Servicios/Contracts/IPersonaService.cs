using Domain.Entities;
using WebApi.DTO.Persona;

namespace Services.Contracts;

public interface IPersonaService
{
    Task<List<Persona>> GetAllAsync(CancellationToken ct);

    Task<Persona> CreatePersonaAsync(CreateDto dto, CancellationToken ct);
}
