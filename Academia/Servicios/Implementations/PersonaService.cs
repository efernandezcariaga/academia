﻿using Domain.Entities;
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
    private const string MENSAJE_LEGAJO_INVALIDO = "El Legajo NO es valido. No se ha podido guardar la Persona.";
    private const string MENSAJE_ERROR_SERVIDOR = "Ha ocurrido un error interno del servidor.";

    public PersonaService(AcademiaContext context)
    {
        _context = context;
    }

    public async Task<PersonaDto> CreatePersonaAsync(PersonaCreateRequest request, CancellationToken ct)
    {
        try
        {
            var plan = await _context.Planes.FirstAsync(x => x.Id == request.PlanId);
            var especialidad = await _context.Especialidades.FirstAsync(x => x.Id == request.EspecialidadId);
            plan.Especialidad = especialidad;

            var personaCreated = request.MapRequestToDomain();
            personaCreated.Plan = plan;

            await _context.Personas.AddAsync(personaCreated);
            await _context.SaveChangesAsync();

            return personaCreated.MapDomainToDto();
        }
        catch (FormatException)
        {
            throw new Exception(MENSAJE_LEGAJO_INVALIDO);
        }
        catch (Exception)
        {
            throw new Exception(MENSAJE_ERROR_SERVIDOR);
        }
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
        return await _context.Personas.Include(x => x.Plan.Especialidad).Select(x => x.MapDomainToDto()).ToListAsync(ct);
    }

    public async Task<PersonaDto?> GetByIdAsync(Guid id, CancellationToken ct)
    {
        var personaById = await _context.Personas.Include(x => x.Plan.Especialidad).FirstOrDefaultAsync(x => x.Id == id, ct);

        return personaById?.MapDomainToDto();
    }

    public async Task<bool> UpdatePersonaAsync(PersonaUpdateRequest request, CancellationToken ct)
    {
        var personaToUpdate = await _context.Personas.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (personaToUpdate == null) return false;

        try
        {
            personaToUpdate.Nombre = request.Nombre;
            personaToUpdate.Apellido = request.Apellido;
            personaToUpdate.Direccion = request.Direccion;
            personaToUpdate.Telefono = request.Telefono;
            personaToUpdate.Email = request.Email;
            personaToUpdate.Legajo = int.Parse(request.Legajo);
            personaToUpdate.FechaNacimiento = request.FechaNacimiento;

            var plan = await _context.Planes.FirstAsync(x => x.Id == request.PlanId);
            var especialidad = await _context.Especialidades.FirstAsync(x => x.Id == request.EspecialidadId);
            plan.Especialidad = especialidad;

            personaToUpdate.Plan = plan;

            await _context.SaveChangesAsync();
            return true;
        }
        catch (FormatException)
        {
            throw new Exception(MENSAJE_LEGAJO_INVALIDO);
        }
        catch (Exception)
        {
            throw new Exception(MENSAJE_ERROR_SERVIDOR);
        }
    }
}