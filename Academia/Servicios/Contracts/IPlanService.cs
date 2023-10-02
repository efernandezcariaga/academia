using WebApi.DTO.Dto;
using WebApi.DTO.Request;

namespace Services.Contracts;

public interface IPlanService
{
    Task<List<PlanDto>> GetAllAsync(CancellationToken ct);

    Task<PlanDto?> GetByIdAsync(Guid id, CancellationToken ct);

    Task<PlanDto> CreatePlanAsync(PlanCreateRequest request, CancellationToken ct);

    Task<bool> UpdatePlanAsync(PlanUpdateRequest request, CancellationToken ct);

    Task<bool> DeletePlanAsync(Guid id, CancellationToken ct);
}