using WebApi.DTO.Dto;
using WebApi.DTO.Request;

namespace Services.Contracts;

public interface IEspecialidadService
{
    Task<List<EspecialidadDto>> GetAllAsync(CancellationToken ct);

    Task<List<EspecialidadDto>> GetAllByPlanIdAsync(Guid planId, CancellationToken ct);

    Task<EspecialidadDto?> GetByIdAsync(Guid id, CancellationToken ct);

    Task<EspecialidadDto> CreateEspecialidadAsync(EspecialidadCreateRequest request, CancellationToken ct);

    Task<bool> UpdateEspecialidadAsync(EspecialidadUpdateRequest request, CancellationToken ct);

    Task<bool> DeleteEspecialidadAsync(Guid id, CancellationToken ct);
}