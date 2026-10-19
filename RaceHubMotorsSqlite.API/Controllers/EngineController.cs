// <copyright file="EngineController.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RaceHubMotorsSqlite.API.DAL.Repository.Interfaces;

namespace RaceHubMotorsSqlite.API.Controllers;

/// <summary>
/// This controller will handle the engine related API endpoints.
/// </summary>
/// <param name="logger">The relevant logging mechanism injection.</param>
/// <param name="engineRepo">The engine repository injection.</param>
[ApiController]
[Route("api/[controller]")]
public class EngineController(ILogger<EngineController> logger, IEngineRepository engineRepo)
{
    private readonly ILogger<EngineController> logger = logger;

    private readonly IEngineRepository engineRepo = engineRepo;
}
