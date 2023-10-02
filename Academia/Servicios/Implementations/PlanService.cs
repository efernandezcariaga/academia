using Domain.Entities;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApi.DTO.Dto;
using WebApi.DTO.Mappers;
using WebApi.DTO.Request;

namespace Services.Implementations;

public class PlanService : IPlanService
{
    private readonly AcademiaContext _context;

    public PlanService(AcademiaContext context)
    {
        _context = context;
    }

    public async Task<PlanDto> CreatePlanAsync(PlanCreateRequest request, CancellationToken ct)
    {
        var planCreated = request.MapRequestToDomain();

        await _context.Planes.AddAsync(planCreated);
        await _context.SaveChangesAsync();

        return planCreated.MapDomainToDto();
    }

    public async Task<bool> DeletePlanAsync(Guid id, CancellationToken ct)
    {
        var planToDelete = await _context.Planes.FirstOrDefaultAsync(x => x.Id == id);

        if (planToDelete == null) return false;

        _context.Planes.Remove(planToDelete);
        await _context.SaveChangesAsync(ct);

        return true;
    }

    public async Task<List<PlanDto>> GetAllAsync(CancellationToken ct)
    {
        return await _context.Planes.Select(x => x.MapDomainToDto()).ToListAsync(ct);
    }

    public async Task<PlanDto?> GetByIdAsync(Guid id, CancellationToken ct)
    {
        var planById = await _context.Planes.FirstOrDefaultAsync(x => x.Id == id, ct);

        return planById?.MapDomainToDto();
    }

    public async Task<bool> UpdatePlanAsync(PlanUpdateRequest request, CancellationToken ct)
    {
        var planToUpdate = await _context.Planes.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (planToUpdate == null) return false;

        planToUpdate.Descripcion = request.Descripcion;
        // TBD: Especialidad

        await _context.SaveChangesAsync();
        return true;
    }
}