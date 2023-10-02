using Domain.Entities;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApi.DTO.Dto;
using WebApi.DTO.Mappers;
using WebApi.DTO.Request;

namespace Services.Implementations
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly AcademiaContext _context;

        public EspecialidadService(AcademiaContext context)
        {
            _context = context;
        }

        public async Task<EspecialidadDto> CreateEspecialidadAsync(EspecialidadCreateRequest request, CancellationToken ct)
        {
            var especialidadCreated = request.MapRequestToDomain();

            await _context.Especialidades.AddAsync(especialidadCreated);
            await _context.SaveChangesAsync();

            return especialidadCreated.MapDomainToDto();
        }

        public async Task<bool> DeleteEspecialidadAsync(Guid id, CancellationToken ct)
        {
            var especialidadToDelete = await _context.Especialidades.FirstOrDefaultAsync(x => x.Id == id);

            if (especialidadToDelete == null) return false;

            _context.Especialidades.Remove(especialidadToDelete);
            await _context.SaveChangesAsync(ct);

            return true;
        }

        public async Task<List<EspecialidadDto>> GetAllAsync(CancellationToken ct)
        {
            return await _context.Especialidades.Select(x => x.MapDomainToDto()).ToListAsync(ct);
        }

        public async Task<EspecialidadDto> GetByIdAsync(Guid id, CancellationToken ct)
        {
            var especialidadById = await _context.Especialidades.FirstOrDefaultAsync(x=>x.Id == id, ct);

            return especialidadById?.MapDomainToDto();
        }

        public async Task<bool> UpdateEspecialidadAsync(EspecialidadUpdateRequest request, CancellationToken ct)
        {
            var especialidadToUpdate = await _context.Especialidades.FirstOrDefaultAsync(x => x.Id == request.Id);
        
            if (especialidadToUpdate == null) return false;
            
            especialidadToUpdate.Descripcion = request.Descripcion;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
