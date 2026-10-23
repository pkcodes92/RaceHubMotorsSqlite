// <copyright file="DeleteEngineResponse.cs" company="PK Codes 92">
// Copyright (c) PK Codes 92. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Response;

/// <summary>
/// This class represents the response when deleting an engine.
/// </summary>
public class DeleteEngineResponse
{
    /// <summary>
    /// A value that indicates if the deletion is successful.
    /// </summary>
    [JsonProperty("isDeleted")]
    [SwaggerSchema(Description = "A boolean value that represents the deletion operation being successful.", Nullable = false)]
    public bool IsDeleted { get; set; }

    /// <summary>
    /// The primary key of the engine that is being deleted.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key of the engine that is being deleted.", Nullable = false)]
    public int Id { get; set; }
}
