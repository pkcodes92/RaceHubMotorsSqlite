// <copyright file="EngineController.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Response;

namespace RaceHubMotorsSqlite.API.Controllers;

/// <summary>
/// This controller will handle the engine related API endpoints.
/// </summary>
/// <param name="logger">The relevant logging mechanism injection.</param>
/// <param name="engineRepo">The engine repository injection.</param>
[ApiController]
[Route("api/[controller]")]
public class EngineController(ILogger<EngineController> logger, IEngineRepository engineRepo) : ControllerBase
{
    private readonly ILogger<EngineController> logger = logger;

    private readonly IEngineRepository engineRepo = engineRepo;

    [HttpGet("GetEngines")]
    public async Task<ActionResult<GetEnginesResponse>> GetEnginesAsync()
    {
        var dbEngines = await this.engineRepo.GetAllEnginesAsync();

        if (dbEngines is not null)
        {
            var dtoEngines = dbEngines.Select(x => x.ToDto()).ToList();

            return this.Ok(new GetEnginesResponse
            {
                Engines = dtoEngines,
            });
        }

        throw new NotFoundException("The engines could not be found!");
    }

    [HttpGet("GetEngineById/{id}")]
    public async Task<ActionResult<GetEngineResponse>> GetEngineByIdAsync(int id)
    {
        var dbEngine = await this.engineRepo.GetEngineByIdAsync(id);

        if (dbEngine is not null)
        {
            return this.Ok(new GetEngineResponse
            {
                Engine = dbEngine.ToDto(),
            });
        }

        throw new NotFoundException("The engine could not be found!");
    }
}
