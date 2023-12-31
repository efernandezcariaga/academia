﻿using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using WebApi.DTO.Mappers;
using WebApi.DTO.Response;

namespace WebApi.Endpoints.Especialidad;

public class GetAll : EndpointBaseAsync
    .WithoutRequest
    .WithActionResult<List<EspecialidadResponse>>
{
    private readonly IEspecialidadService _especialidadService;

    public GetAll(IEspecialidadService especialidadService)
    {
        _especialidadService = especialidadService;
    }

    [HttpGet("api/especialidades")]
    public async override Task<ActionResult<List<EspecialidadResponse>>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var results = await _especialidadService.GetAllAsync(cancellationToken);

        return results.Select(x => x.MapDtoToResponse()).ToList();
    }
}
