// <copyright file="EngineController.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RaceHubMotorsSqlite.API.DAL.Models;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;
using RaceHubMotorsSqlite.API.DTO.Request;
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

        return this.NotFound("The engines could not be found!");
    }

    [HttpGet("GetEngineById/{id}")]
    public async Task<ActionResult<GetEngineResponse>> GetEngineByIdAsync(int id)
    {
        var dbEngine = await this.engineRepo.GetEngineAsync(id);

        if (dbEngine is not null)
        {
            return this.Ok(new GetEngineResponse
            {
                Engine = dbEngine.ToDto(),
            });
        }

        return this.NotFound("The engine could not be found!");
    }

    [HttpGet("GetEngineByCode/{code}")]
    public async Task<ActionResult<GetEngineResponse>> GetEngineByCodeAsync(string code)
    {
        var dbEngine = await this.engineRepo.GetEngineAsync(code);

        if (dbEngine is not null)
        {
            return this.Ok(new GetEngineResponse
            {
                Engine = dbEngine.ToDto(),
            });
        }

        return this.NotFound("The engine could not be found!");
    }

    [HttpPost("AddEngine")]
    public async Task<ActionResult<AddEngineResponse>> AddEngineAsync([FromBody] AddEngineRequest request)
    {
        var newEngine = request.ToEntity();

        var dbEngine = await this.engineRepo.AddEngineAsync(newEngine);

        if (dbEngine is not null)
        {
            return this.Ok(new AddEngineResponse
            {
                Engine = dbEngine.ToDto(),
            });
        }

        return this.UnprocessableEntity("The engine could not be added!");
    }

    [HttpPost("UpdateEngine")]
    public async Task<ActionResult<UpdateEngineResponse>> UpdateEngineAsync(
        [FromRoute] int id,
        [FromBody] UpdateEngineRequest request)
    {
        var updatedEngine = await this.engineRepo.GetEngineAsync(id);

        updatedEngine.Code = request.Code;
        updatedEngine.Description = request.Description;
        updatedEngine.EngineId = id;

        var dbResult = await this.engineRepo.UpdateEngineAsync(updatedEngine);

        if (dbResult is not null)
        {
            return this.Ok(new UpdateEngineResponse
            {
                Engine = dbResult.ToDto(),
            });
        }

        return this.UnprocessableEntity("The engine could not be updated!");
    }

    [HttpPost("DeleteEngine/{id}")]
    public async Task<ActionResult<DeleteEngineResponse>> DeleteEngineAsync([FromRoute] int id)
    {
        var engineToDelete = await this.engineRepo.GetEngineAsync(id);

        var dbResult = await this.engineRepo.DeleteEngineAsync(engineToDelete!);

        if (dbResult)
        {
            return this.Ok(new DeleteEngineResponse
            {
                IsDeleted = true,
                Id = id,
            });
        }

        return this.UnprocessableEntity("The engine could not be deleted!");
    }
}
