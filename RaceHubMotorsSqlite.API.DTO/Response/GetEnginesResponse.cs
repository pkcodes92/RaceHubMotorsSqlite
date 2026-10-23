// <copyright file="GetEnginesResponse.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using RaceHubMotorsSqlite.API.DTO.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class represents the relevant response when getting the engines from the database.
/// </summary>
public class GetEnginesResponse
{
    /// <summary>
    /// The list of the engines in the database.
    /// </summary>
    [JsonProperty("engines")]
    [SwaggerSchema(Description = "The list of the engines in the database.", Nullable = false)]
    public List<Engine> Engines { get; set; } = null!;
}
