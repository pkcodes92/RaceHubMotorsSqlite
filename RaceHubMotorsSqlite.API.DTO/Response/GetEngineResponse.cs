// <copyright file="GetEngineResponse.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using RaceHubMotorsSqlite.API.DTO.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class represents the response when getting an engine.
/// </summary>
public class GetEngineResponse
{
    /// <summary>
    /// The engine that is retrieved.
    /// </summary>
    [JsonProperty("engine")]
    [SwaggerSchema(Description = "The engine that is retrieved from the database.", Nullable = false, Format = "object")]
    public Engine Engine { get; set; } = null!;
}