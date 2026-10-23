// <copyright file="UpdateEngineResponse.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using RaceHubMotorsSqlite.API.DTO.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class represents the response when an engine is updated.
/// </summary>
public class UpdateEngineResponse
{
    /// <summary>
    /// The relevated engine in the database.
    /// </summary>
    [JsonProperty("engine")]
    [SwaggerSchema(Description = "The updated engine.", Nullable = false)]
    public Engine Engine { get; set; } = null!;
}
