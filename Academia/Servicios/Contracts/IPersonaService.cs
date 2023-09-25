using WebApi.DTO.Dto;
using WebApi.DTO.Request;

namespace Services.Contracts;

public interface IPersonaService
{
    Task<List<PersonaDto>> GetAllAsync(CancellationToken ct);

    Task<PersonaDto?> GetByIdAsync(Guid id, CancellationToken ct);

    Task<PersonaDto> CreatePersonaAsync(PersonaCreateRequest request, CancellationToken ct);

    Task<bool> UpdatePersonaAsync(PersonaUpdateRequest request, CancellationToken ct);

    Task<bool> DeletePersonaAsync(Guid id, CancellationToken ct);
}
