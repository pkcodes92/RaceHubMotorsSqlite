// <copyright file="GetDrivetrainsResponse.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using RaceHubMotorsSqlite.API.DTO.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class contains all the drivetrains.
/// </summary>
[SwaggerSchema(Description = "The response that contains all the drivetrains.")]
public class GetDrivetrainsResponse
{
    /// <summary>
    /// Gets or sets the list of the drivetrains from the database.
    /// </summary>
    [JsonProperty("drivetrains")]
    [SwaggerSchema(Description = "The list of the drivetrains.")]
    public List<Drivetrain> Drivetrains { get; set; } = null!;
}
