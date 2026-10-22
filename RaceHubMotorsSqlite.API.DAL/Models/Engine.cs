// <copyright file="Engine.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

namespace RaceHubMotorsSqlite.API.DAL.Models;

/// <summary>
/// This class represents the engine database entity.
/// </summary>
public class Engine
{
    /// <summary>
    /// Gets or sets the engine ID - the primary key.
    /// </summary>
    public int EngineId { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// This class extends the Engine database entity.
/// </summary>
public static class EngineExtensions
{
    /// <summary>
    /// Converts the engine database entity to its corresponding DTO representation.
    /// </summary>
    /// <param name="engine">The engine database entity.</param>
    /// <returns>The DTO representation of the engine.</returns>
    public static DTO.Models.Engine ToDto(this Engine engine)
    {
        return new DTO.Models.Engine
        {
            Id = engine.EngineId,
            Code = engine.Code,
            Description = engine.Description,
        };
    }

    public static Engine ToEntity(this DTO.Request.AddEngineRequest request)
    {
        return new Engine
        {
            Code = request.Code,
            Description = request.Description,
        };
    }
}