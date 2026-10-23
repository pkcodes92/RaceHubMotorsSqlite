// <copyright file="AddVehicleTypeRequest.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This class represents the request when adding a new vehicle type.
/// </summary>
[SwaggerSchema(Description = "The request when adding a new vehicle type")]
public class AddVehicleTypeRequest
{
    /// <summary>
    /// Gets or sets the vehicle type code.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the new vehicle type")]
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// The description of the new vehicle type.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the new vehicle type")]
    public string Description { get; set; } = string.Empty;
}