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

    /// <summary>
    /// This endpoint will return all the engines in the database.
    /// </summary>
    /// <returns>
    /// A unit of execution that contains type of <see cref="ActionResult{TValue}"/> which contains a type of
    /// <see cref="GetEnginesResponse"/>.
    /// </returns>
    [HttpGet("GetEngines")]
    public async Task<ActionResult<GetEnginesResponse>> GetEnginesAsync()
    {
        this.logger.LogInformation("Getting all the engines");

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

    /// <summary>
    /// This endpoint will get a single engine from the database by searching the primary key.
    /// </summary>
    /// <param name="id">The primary key of the engine to search.</param>
    /// <returns>
    /// A unit of execution that contains a type of <see cref="ActionResult{TValue}"/> which contains a type of
    /// <see cref="GetEngineResponse"/>.
    /// </returns>
    [HttpGet("GetEngineById/{id}")]
    public async Task<ActionResult<GetEngineResponse>> GetEngineByIdAsync(int id)
    {
        this.logger.LogInformation("Getting the engine by the ID");

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

    /// <summary>
    /// This endpoint will get the relevant engine by the code.
    /// </summary>
    /// <param name="code">The code of the engine to search.</param>
    /// <returns>
    /// A unit of execution that contains a type of <see cref="ActionResult{TValue}"/> which contains a type of
    /// <see cref="GetEngineResponse"/>.
    /// </returns>
    [HttpGet("GetEngineByCode/{code}")]
    public async Task<ActionResult<GetEngineResponse>> GetEngineByCodeAsync([FromRoute] string code)
    {
        this.logger.LogInformation("Getting the engine by the code");

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

    /// <summary>
    /// This endpoint will be inserting a new engine to the database.
    /// </summary>
    /// <param name="request">The new engine information to insert.</param>
    /// <returns>
    /// A unit of execution that contains a type of <see cref="ActionResult{TValue}"/> which contains a type of
    /// <see cref="AddEngineResponse"/>.
    /// </returns>
    [HttpPost("AddEngine")]
    public async Task<ActionResult<AddEngineResponse>> AddEngineAsync([FromBody] AddEngineRequest request)
    {
        this.logger.LogInformation("Adding a new engine");

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

    /// <summary>
    /// This endpoint will update an existing engine with the relevant information.
    /// </summary>
    /// <param name="id">The primary key of the engine to update.</param>
    /// <param name="request">The updated information about the engine.</param>
    /// <returns>
    /// A unit of execution that contains type of <see cref="ActionResult{TValue}"/> which contains a type of
    /// <see cref="UpdateEngineResponse"/>.
    /// </returns>
    [HttpPost("UpdateEngine")]
    public async Task<ActionResult<UpdateEngineResponse>> UpdateEngineAsync(
        [FromRoute] int id,
        [FromBody] UpdateEngineRequest request)
    {
        this.logger.LogInformation("Updating the engine");

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

    /// <summary>
    /// This endpoint will remove an engine from the database.
    /// </summary>
    /// <param name="id">The primary key of the engine to delete.</param>
    /// <returns>
    /// A unit of execution that contains type of <see cref="ActionResult{TValue}"/> which contains a type of
    /// <see cref="DeleteEngineResponse"/>.
    /// </returns>
    [HttpPost("DeleteEngine/{id}")]
    public async Task<ActionResult<DeleteEngineResponse>> DeleteEngineAsync([FromRoute] int id)
    {
        this.logger.LogInformation("Deleting the engine");

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
