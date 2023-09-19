using Domain.Entities;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using WebApi.DTO.Persona;

namespace Services.Implementations;

public class PersonaService : IPersonaService
{
    private readonly AcademiaContext _context;

    public PersonaService(AcademiaContext context)
    {
        _context = context;
    }

    public async Task<Persona> CreatePersonaAsync(CreateDto dto, CancellationToken ct)
    {
        var personaCreated = new Persona
        {
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            Direccion = dto.Direccion,
            Email = dto.Email,
            Legajo = dto.Legajo,
            Telefono = dto.Telefono,
        };
        await _context.Personas.AddAsync(personaCreated);
        await _context.SaveChangesAsync();

        return personaCreated;
    }

    public async Task<List<Persona>> GetAllAsync(CancellationToken ct)
    {
        return await _context.Personas.ToListAsync(ct);
    }
}