using Domain.Entities;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApi.DTO.Dto;
using WebApi.DTO.Mappers;
using WebApi.DTO.Request;

namespace Services.Implementations;

public class PersonaService : IPersonaService
{
    private readonly AcademiaContext _context;

    public PersonaService(AcademiaContext context)
    {
        _context = context;
    }

    public async Task<PersonaDto> CreatePersonaAsync(PersonaCreateRequest request, CancellationToken ct)
    {
        var personaCreated = request.MapRequestToDomain();

        await _context.Personas.AddAsync(personaCreated);
        await _context.SaveChangesAsync();

        return personaCreated.MapDomainToDto();
    }

    public async Task<bool> DeletePersonaAsync(Guid id, CancellationToken ct)
    {
        var personaToDelete = await _context.Personas.FirstOrDefaultAsync(x => x.Id == id);

        if (personaToDelete == null) return false;

        _context.Personas.Remove(personaToDelete);
        await _context.SaveChangesAsync(ct);

        return true;
    }

    public async Task<List<PersonaDto>> GetAllAsync(CancellationToken ct)
    {
        return await _context.Personas.Select(x => x.MapDomainToDto()).ToListAsync(ct);
    }

    public async Task<PersonaDto?> GetByIdAsync(Guid id, CancellationToken ct)
    {
        var personaById = await _context.Personas.FirstOrDefaultAsync(x => x.Id == id, ct);

        return personaById?.MapDomainToDto();
    }

    public async Task<bool> UpdatePersonaAsync(PersonaUpdateRequest request, CancellationToken ct)
    {
        var personaToUpdate = await _context.Personas.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (personaToUpdate == null) return false;

        personaToUpdate.Nombre = request.Nombre;
        personaToUpdate.Apellido = request.Apellido;
        personaToUpdate.Direccion = request.Direccion;
        personaToUpdate.Telefono = request.Telefono;
        personaToUpdate.Email = request.Email;
        personaToUpdate.Legajo = request.Legajo;
        // TBD: Fecha nacimiento y Plan

        await _context.SaveChangesAsync();
        return true;
    }
}