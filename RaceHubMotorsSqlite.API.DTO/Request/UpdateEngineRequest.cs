#nullable disable

using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace RaceHubMotorsSqlite.API.DTO.Request;

/// <summary>
/// This is the request for an existing engine to be updated.
/// </summary>
public class UpdateEngineRequest
{
    /// <summary>
    /// This is the primary key of the engine being updated.
    /// </summary>
    [JsonProperty("id")]
    [SwaggerSchema(Description = "The primary key of the Engine ID to be updated")]
    public int Id { get; set; }

    /// <summary>
    /// The code of the engine being updated.
    /// </summary>
    [JsonProperty("code")]
    [SwaggerSchema(Description = "The code of the engine being updated")]
    public string Code { get; set; }

    /// <summary>
    /// The description of the engine being updated.
    /// </summary>
    [JsonProperty("description")]
    [SwaggerSchema(Description = "The description of the updated engine information")]
    public string Description { get; set; }
}