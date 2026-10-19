// <copyright file="AddEngineResponse.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using RaceHubMotorsSqlite.API.DTO.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class represents the response when a new engine is added.
/// </summary>
[SwaggerSchema(Description = "The response when a new engine is added.")]
public class AddEngineResponse
{
    /// <summary>
    /// Gets or sets the newly added engine.
    /// </summary>
    [JsonProperty("engine")]
    [SwaggerSchema(Description = "The newly added engine.")]
    public Engine Engine { get; set; } = null!;
}
